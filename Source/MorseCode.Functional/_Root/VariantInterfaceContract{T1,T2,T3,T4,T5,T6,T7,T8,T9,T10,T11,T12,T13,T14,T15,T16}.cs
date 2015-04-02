#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VariantInterfaceContract{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}.cs" company="MorseCode Software">
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

    [ContractClassFor(typeof(IVariant<,,,,,,,,,,,,,,,>))]
    internal abstract class VariantInterfaceContract<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        #region Explicit Interface Properties

        object IVariantWithCommon<object>.Value
        {
            get
            {
                return null;
            }
        }

        #endregion

        #region Explicit Interface Methods

        void IVariantWithCommon<object, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth, Action<T9> ninth, Action<T10> tenth, Action<T11> eleventh, Action<T12> twelfth, Action<T13> thirteenth, Action<T14> fourteenth, Action<T15> fifteenth, Action<T16> sixteenth)
        {
        }

        TResult IVariantWithCommon<object, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth, Func<T9, TResult> ninth, Func<T10, TResult> tenth, Func<T11, TResult> eleventh, Func<T12, TResult> twelfth, Func<T13, TResult> thirteenth, Func<T14, TResult> fourteenth, Func<T15, TResult> fifteenth, Func<T16, TResult> sixteenth)
        {
            return default(TResult);
        }

        void IVariantWithCommon<object, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth, Action<T9> ninth, Action<T10> tenth, Action<T11> eleventh, Action<T12> twelfth, Action<T13> thirteenth, Action<T14> fourteenth, Action<T15> fifteenth, Action<T16> sixteenth)
        {
        }

        TResult IVariantWithCommon<object, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth, Func<T9, TResult> ninth, Func<T10, TResult> tenth, Func<T11, TResult> eleventh, Func<T12, TResult> twelfth, Func<T13, TResult> thirteenth, Func<T14, TResult> fourteenth, Func<T15, TResult> fifteenth, Func<T16, TResult> sixteenth)
        {
            return default(TResult);
        }

        #endregion
    }
}