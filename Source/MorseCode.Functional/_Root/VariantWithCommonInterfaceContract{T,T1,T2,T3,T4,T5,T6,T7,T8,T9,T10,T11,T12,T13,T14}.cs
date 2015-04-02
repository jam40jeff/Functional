#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VariantWithCommonInterfaceContract{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}.cs" company="MorseCode Software">
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

namespace MorseCode.Functional
{
    using System;
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IVariantWithCommon<,,,,,,,,,,,,,,>))]
    internal abstract class VariantWithCommonInterfaceContract<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
        where T1 : T
        where T2 : T
        where T3 : T
        where T4 : T
        where T5 : T
        where T6 : T
        where T7 : T
        where T8 : T
        where T9 : T
        where T10 : T
        where T11 : T
        where T12 : T
        where T13 : T
        where T14 : T
    {
        #region Explicit Interface Properties

        T IVariantWithCommon<T>.Value
        {
            get
            {
                return default(T);
            }
        }

        #endregion

        #region Explicit Interface Methods

        void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth, Action<T9> ninth, Action<T10> tenth, Action<T11> eleventh, Action<T12> twelfth, Action<T13> thirteenth, Action<T14> fourteenth)
        {
            Contract.Requires<ArgumentNullException>(first != null, "first");
            Contract.Requires<ArgumentNullException>(second != null, "second");
            Contract.Requires<ArgumentNullException>(third != null, "third");
            Contract.Requires<ArgumentNullException>(fourth != null, "fourth");
            Contract.Requires<ArgumentNullException>(fifth != null, "fifth");
            Contract.Requires<ArgumentNullException>(sixth != null, "sixth");
            Contract.Requires<ArgumentNullException>(seventh != null, "seventh");
            Contract.Requires<ArgumentNullException>(eighth != null, "eighth");
            Contract.Requires<ArgumentNullException>(ninth != null, "ninth");
            Contract.Requires<ArgumentNullException>(tenth != null, "tenth");
            Contract.Requires<ArgumentNullException>(eleventh != null, "eleventh");
            Contract.Requires<ArgumentNullException>(twelfth != null, "twelfth");
            Contract.Requires<ArgumentNullException>(thirteenth != null, "thirteenth");
            Contract.Requires<ArgumentNullException>(fourteenth != null, "fourteenth");
        }

        TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth, Func<T9, TResult> ninth, Func<T10, TResult> tenth, Func<T11, TResult> eleventh, Func<T12, TResult> twelfth, Func<T13, TResult> thirteenth, Func<T14, TResult> fourteenth)
        {
            Contract.Requires<ArgumentNullException>(first != null, "first");
            Contract.Requires<ArgumentNullException>(second != null, "second");
            Contract.Requires<ArgumentNullException>(third != null, "third");
            Contract.Requires<ArgumentNullException>(fourth != null, "fourth");
            Contract.Requires<ArgumentNullException>(fifth != null, "fifth");
            Contract.Requires<ArgumentNullException>(sixth != null, "sixth");
            Contract.Requires<ArgumentNullException>(seventh != null, "seventh");
            Contract.Requires<ArgumentNullException>(eighth != null, "eighth");
            Contract.Requires<ArgumentNullException>(ninth != null, "ninth");
            Contract.Requires<ArgumentNullException>(tenth != null, "tenth");
            Contract.Requires<ArgumentNullException>(eleventh != null, "eleventh");
            Contract.Requires<ArgumentNullException>(twelfth != null, "twelfth");
            Contract.Requires<ArgumentNullException>(thirteenth != null, "thirteenth");
            Contract.Requires<ArgumentNullException>(fourteenth != null, "fourteenth");

            return default(TResult);
        }

        void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth, Action<T9> ninth, Action<T10> tenth, Action<T11> eleventh, Action<T12> twelfth, Action<T13> thirteenth, Action<T14> fourteenth)
        {
            Contract.Requires<ArgumentNullException>(otherwise != null, "otherwise");
        }

        TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth, Func<T9, TResult> ninth, Func<T10, TResult> tenth, Func<T11, TResult> eleventh, Func<T12, TResult> twelfth, Func<T13, TResult> thirteenth, Func<T14, TResult> fourteenth)
        {
            Contract.Requires<ArgumentNullException>(otherwise != null, "otherwise");

            return default(TResult);
        }

        #endregion
    }
}