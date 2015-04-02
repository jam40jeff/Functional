#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VariantWithCommonInterfaceContract{T,T1,T2}.cs" company="MorseCode Software">
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

    [ContractClassFor(typeof(IVariantWithCommon<,,>))]
    internal abstract class VariantWithCommonInterfaceContract<T, T1, T2> : IVariantWithCommon<T, T1, T2>
        where T1 : T
        where T2 : T
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

        void IVariantWithCommon<T, T1, T2>.Match(Action<T1> first, Action<T2> second)
        {
            Contract.Requires<ArgumentNullException>(first != null, "first");
            Contract.Requires<ArgumentNullException>(second != null, "second");
        }

        TResult IVariantWithCommon<T, T1, T2>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second)
        {
            Contract.Requires<ArgumentNullException>(first != null, "first");
            Contract.Requires<ArgumentNullException>(second != null, "second");

            return default(TResult);
        }

        void IVariantWithCommon<T, T1, T2>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second)
        {
            Contract.Requires<ArgumentNullException>(otherwise != null, "otherwise");
        }

        TResult IVariantWithCommon<T, T1, T2>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second)
        {
            Contract.Requires<ArgumentNullException>(otherwise != null, "otherwise");

            return default(TResult);
        }

        #endregion
    }
}