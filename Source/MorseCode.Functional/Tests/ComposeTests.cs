#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComposeTests.cs" company="MorseCode Software">
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

    using MorseCode.Functional;

    using NUnit.Framework;

    [TestFixture]
    public class ComposeTests
    {
        #region Public Methods and Operators

        [Test]
        public void ComposeWithNoArguments()
        {
            Func<int, int> square = x => x * x;
            Func<int> return5 = () => 5;
            Func<int> squareDotReturn5 = square.Compose(return5);

            Assert.AreEqual(25, squareDotReturn5());
        }

        [Test]
        public void ComposeWithOneArgument()
        {
            Func<int, int> square = x => x * x;
            Func<int, int> add5 = x => x + 5;
            Func<int, int> squareDotAdd5 = square.Compose(add5);

            Assert.AreEqual(81, squareDotAdd5(4));
        }

        [Test]
        public void ComposeWithTwoArguments()
        {
            Func<int, int> square = x => x * x;
            Func<int, int, int> add = (a, b) => a + b;
            Func<int, int, int> squareDotAdd = square.Compose(add);

            Assert.AreEqual(64, squareDotAdd(5, 3));
        }

        #endregion
    }
}