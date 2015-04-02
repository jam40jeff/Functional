#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VariantTests.cs" company="MorseCode Software">
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
    using System.Globalization;

    using MorseCode.Functional;

    using NUnit.Framework;

    [TestFixture]
    public class VariantTests
    {
        [Test]
        public void TestThreeTypeVariantWithSecond()
        {
            IVariant<int, string, double> v = Variant.Second<int, string, double>("test");

            string actionResult = null;
            v.Match(_ => { }, s => actionResult = s, __ => { });
            Assert.AreEqual("test", actionResult);

            string funcResult = v.Match(_ => null, s => s, __ => null);
            Assert.AreEqual("test", funcResult);

            string actionMatchSomeResult = null;
            v.MatchSome(() => actionMatchSomeResult = "other", i => actionMatchSomeResult = i.ToString(CultureInfo.InvariantCulture), third: d => actionMatchSomeResult = d.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("other", actionMatchSomeResult);

            string actionMatchSomeResultMatched = null;
            v.MatchSome(() => actionMatchSomeResultMatched = "other", second: s => actionMatchSomeResultMatched = s, third: d => actionMatchSomeResultMatched = d.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("test", actionMatchSomeResultMatched);

            string funcMatchSomeResult = v.MatchSome(() => "other", i => i.ToString(CultureInfo.InvariantCulture), third: d => d.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("other", funcMatchSomeResult);

            string funcMatchSomeResultMatched = v.MatchSome(() => "other", second: s => s, third: d => d.ToString(CultureInfo.InvariantCulture));
            Assert.AreEqual("test", funcMatchSomeResultMatched);
        }

        [Test]
        public void TestThreeTypeVariantWithCommon()
        {
            A a = new A();
            B b = new B();
            C c = new C();
            IVariantWithCommon<Base, A, B, C> aVariant = Variant.FirstWithCommon<Base, A, B, C>(a);
            IVariantWithCommon<Base, A, B, C> bVariant = Variant.SecondWithCommon<Base, A, B, C>(b);
            IVariantWithCommon<Base, A, B, C> cVariant = Variant.ThirdWithCommon<Base, A, B, C>(c);

            Assert.AreSame(a, aVariant.Value);
            Assert.AreSame(b, bVariant.Value);
            Assert.AreSame(c, cVariant.Value);
        }

        [Test]
        public void FlattenThreeTypeVariant()
        {
            IVariant<int, IVariant<int, string, double>, double> v = Variant.Second<int, IVariant<int, string, double>, double>(Variant.Second<int, string, double>("test"));
            IVariant<int, string, double> flattenedVariant = v.Flatten();

            Assert.AreEqual("test", flattenedVariant.MatchSome(() => "other", second: s => s));
        }

        private abstract class Base
        {
        }

        private class A : Base
        {
        }

        private class B : Base
        {
        }

        private class C : Base
        {
        }
    }
}