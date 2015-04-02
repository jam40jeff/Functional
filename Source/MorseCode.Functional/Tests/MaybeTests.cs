#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MaybeTests.cs" company="MorseCode Software">
// Copyright (c) 2015 MorseCode Software
// </copyright>
// <summary>
// The MIT License (MIT)
// 
// Copyright (c) 2015 MorseCode Software
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
#endregion

namespace Tests
{
    using System;
    using System.Globalization;

    using MorseCode.FrameworkExtensions;
    using MorseCode.Functional;

    using NUnit.Framework;

    [TestFixture]
    public class MaybeTests
    {
        #region Public Methods and Operators

        [Test]
        public void Test()
        {
            IMaybe<int> a = Maybe.Just(5);

            Assert.AreEqual(5, a.Match(v => v, () => { throw new InvalidOperationException("A value was expected."); }));
        }

        [Test]
        public void TestNothing()
        {
            IMaybe<int> a = Maybe.Nothing<int>();

            Assert.AreEqual(Unit.Value, a.Match(v => { throw new InvalidOperationException("No value was expected."); }, () => Unit.Value));
        }

        [Test]
        public void TestMonad()
        {
            IMaybe<int> a = Maybe.Just(5);
            IMaybe<int> b = Maybe.Just(7);
            IMaybe<int> c = Maybe.Just(3);
            IMaybe<int> result = from aValue in a from bValue in b from cValue in c select aValue + bValue + cValue;

            Assert.AreEqual(15, result.Match(v => v, () => { throw new InvalidOperationException("A value was expected."); }));
        }

        [Test]
        public void TestMonadWithNothing()
        {
            IMaybe<int> a = Maybe.Nothing<int>();
            IMaybe<int> b = Maybe.Just(7);
            IMaybe<int> c = Maybe.Just(3);
            IMaybe<int> result = from aValue in a from bValue in b from cValue in c select aValue + bValue + cValue;

            Assert.AreEqual(Unit.Value, result.Match(v => { throw new InvalidOperationException("No value was expected."); }, () => Unit.Value));
        }

        [Test]
        public void TestMonadChangeType()
        {
            IMaybe<int> a = Maybe.Just(5);
            IMaybe<int> b = Maybe.Just(7);
            IMaybe<int> c = Maybe.Just(3);
            IMaybe<string> result = from aValue in a from bValue in b from cValue in c select (aValue + bValue + cValue).ToString(CultureInfo.InvariantCulture);

            Assert.AreEqual("15", result.Match(v => v, () => { throw new InvalidOperationException("A value was expected."); }));
        }

        [Test]
        public void TestMonadChangeTypeWithNothing()
        {
            IMaybe<int> a = Maybe.Nothing<int>();
            IMaybe<int> b = Maybe.Just(7);
            IMaybe<int> c = Maybe.Just(3);
            IMaybe<string> result = from aValue in a from bValue in b from cValue in c select (aValue + bValue + cValue).ToString(CultureInfo.InvariantCulture);

            Assert.AreEqual(Unit.Value, result.Match(v => { throw new InvalidOperationException("No value was expected."); }, () => Unit.Value));
        }

        #endregion
    }
}