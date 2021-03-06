﻿#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IVariantWithCommon{T,T1,T2,T3}.cs" company="MorseCode Software">
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

    /// <summary>
    /// An interface representing a variant (or discriminated union) type which may hold one value of any of the types <typeparamref name="T1"/>, <typeparamref name="T2"/>, or <typeparamref name="T3"/>
    /// all of which inherit from or implement a common type <typeparamref name="T"/>.
    /// </summary>
    /// <typeparam name="T">
    /// The common type all possible values of the variant (or discriminated union) inherit from or implement.
    /// </typeparam>
    /// <typeparam name="T1">
    /// The type of the first possible value of the variant (or discriminated union).
    /// </typeparam>
    /// <typeparam name="T2">
    /// The type of the second possible value of the variant (or discriminated union).
    /// </typeparam>
    /// <typeparam name="T3">
    /// The type of the third possible value of the variant (or discriminated union).
    /// </typeparam>
    [ContractClass(typeof(VariantWithCommonInterfaceContract<,,,>))]
    public interface IVariantWithCommon<out T, out T1, out T2, out T3> : IVariantWithCommon<T>
        where T1 : T
        where T2 : T
        where T3 : T
    {
        #region Public Methods and Operators

        /// <summary>
        /// Executes an action based on which value is contained in the variant (or discriminated union).
        /// </summary>
        /// <param name="first">
        /// The action to run if the value stored in the variant (or discriminated union) is of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </param>
        /// <param name="second">
        /// The action to run if the value stored in the variant (or discriminated union) is of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </param>
        /// <param name="third">
        /// The action to run if the value stored in the variant (or discriminated union) is of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </param>
        void Match(Action<T1> first, Action<T2> second, Action<T3> third);

        /// <summary>
        /// Executes a function based on which value is contained in the variant (or discriminated union).
        /// </summary>
        /// <param name="first">
        /// The function to run if the value stored in the variant (or discriminated union) is of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </param>
        /// <param name="second">
        /// The function to run if the value stored in the variant (or discriminated union) is of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </param>
        /// <param name="third">
        /// The function to run if the value stored in the variant (or discriminated union) is of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </param>
        /// <typeparam name="TResult">
        /// The type of the result.
        /// </typeparam>
        /// <returns>
        /// The result of type <typeparamref name="TResult"/> of the function executed.
        /// </returns>
        TResult Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third);

        /// <summary>
        /// Executes an action based on which value is contained in the variant (or discriminated union).
        /// </summary>
        /// <param name="otherwise">
        /// The action to execute if the value stored in the variant (or discriminated union) is of a possible variant value which was passed a corresponding <c>null</c> delegate.
        /// </param>
        /// <param name="first">
        /// The action to run if the value stored in the variant (or discriminated union) is of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </param>
        /// <param name="second">
        /// The action to run if the value stored in the variant (or discriminated union) is of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </param>
        /// <param name="third">
        /// The action to run if the value stored in the variant (or discriminated union) is of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </param>
        void MatchSome(Action otherwise, Action<T1> first = null, Action<T2> second = null, Action<T3> third = null);

        /// <summary>
        /// Executes a function based on which value is contained in the variant (or discriminated union).
        /// </summary>
        /// <param name="otherwise">
        /// The function to execute if the value stored in the variant (or discriminated union) is of a possible variant value which was passed a corresponding <c>null</c> delegate.
        /// </param>
        /// <param name="first">
        /// The function to run if the value stored in the variant (or discriminated union) is of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </param>
        /// <param name="second">
        /// The function to run if the value stored in the variant (or discriminated union) is of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </param>
        /// <param name="third">
        /// The function to run if the value stored in the variant (or discriminated union) is of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </param>
        /// <typeparam name="TResult">
        /// The type of the result.
        /// </typeparam>
        /// <returns>
        /// The result of type <typeparamref name="TResult"/> of the function executed.
        /// </returns>
        TResult MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first = null, Func<T2, TResult> second = null, Func<T3, TResult> third = null);

        #endregion
    }
}