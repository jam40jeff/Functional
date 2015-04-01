#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlipExtensionMethod.cs" company="MorseCode Software">
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
    /// Provides the flip extension method, which can be called on a method with two parameters to reverse the order of its parameters.
    /// </summary>
    public static class FlipExtensionMethod
    {
        #region Public Methods and Operators

        /// <summary>
        /// Flips the parameters for a function delegate taking two parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to flip.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with the original function delegate's parameters flipped.
        /// </returns>
        public static Func<T2, T1, TResult> Flip<T1, T2, TResult>(this Func<T1, T2, TResult> func)
        {
            return (a, b) => func(b, a);
        }

        /// <summary>
        /// Flips the parameters for a curried function delegate taking two parameters.
        /// </summary>
        /// <param name="func">
        /// The curried function delegate to flip.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A curried function delegate with the original curried function delegate's parameters flipped.
        /// </returns>
        public static Func<T2, Func<T1, TResult>> Flip<T1, T2, TResult>(this Func<T1, Func<T2, TResult>> func)
        {
            return b => a => func(a)(b);
        }

        #endregion
    }
}