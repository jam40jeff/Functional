﻿#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMaybe{T}.cs" company="MorseCode Software">
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

    /// <summary>
    /// An interface representing an instance which may or may not have a value.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value.
    /// </typeparam>
    public interface IMaybe<out T>
    {
        #region Public Methods and Operators

        /// <summary>
        /// Executes an action based on whether or not the instance has a value.
        /// </summary>
        /// <param name="hasValueAction">
        /// The action to run if the instance has a value.
        /// </param>
        /// <param name="nothingAction">
        /// The action to run if the instance does not have a value.
        /// </param>
        void Match(Action<T> hasValueAction, Action nothingAction);

        /// <summary>
        /// Executes an function based on whether or not the instance has a value.
        /// </summary>
        /// <param name="hasValueFunc">
        /// The function to run if the instance has a value.
        /// </param>
        /// <param name="nothingFunc">
        /// The function to run if the instance does not have a value.
        /// </param>
        /// <typeparam name="TResult">
        /// The return type of the function.
        /// </typeparam>
        /// <returns>
        /// The result of type <typeparamref name="TResult"/> of the function executed.
        /// </returns>
        TResult Match<TResult>(Func<T, TResult> hasValueFunc, Func<TResult> nothingFunc);

        #endregion
    }
}