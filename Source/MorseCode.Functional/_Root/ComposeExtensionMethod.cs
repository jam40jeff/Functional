#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ComposeExtensionMethod.cs" company="MorseCode Software">
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
    /// Provides the compose extension method, which can be called on a function to compose it with a second function.
    /// </summary>
    public static class ComposeExtensionMethod
    {
        #region Public Methods and Operators

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<TResult> Compose<TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<TIntermediateResult> secondFunc)
        {
            return () => firstFunc(secondFunc());
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, TResult> Compose<T1, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, TIntermediateResult> secondFunc)
        {
            return a => firstFunc(secondFunc(a));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, TResult> Compose<T1, T2, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, TIntermediateResult> secondFunc)
        {
            return (a, b) => firstFunc(secondFunc(a, b));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, TResult> Compose<T1, T2, T3, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, TIntermediateResult> secondFunc)
        {
            return (a, b, c) => firstFunc(secondFunc(a, b, c));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, TResult> Compose<T1, T2, T3, T4, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d) => firstFunc(secondFunc(a, b, c, d));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, TResult> Compose<T1, T2, T3, T4, T5, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, T5, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d, e) => firstFunc(secondFunc(a, b, c, d, e));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, TResult> Compose<T1, T2, T3, T4, T5, T6, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, T5, T6, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d, e, f) => firstFunc(secondFunc(a, b, c, d, e, f));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, TResult> Compose<T1, T2, T3, T4, T5, T6, T7, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, T5, T6, T7, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d, e, f, g) => firstFunc(secondFunc(a, b, c, d, e, f, g));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, T5, T6, T7, T8, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d, e, f, g, h) => firstFunc(secondFunc(a, b, c, d, e, f, g, h));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d, e, f, g, h, i) => firstFunc(secondFunc(a, b, c, d, e, f, g, h, i));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d, e, f, g, h, i, j) => firstFunc(secondFunc(a, b, c, d, e, f, g, h, i, j));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d, e, f, g, h, i, j, k) => firstFunc(secondFunc(a, b, c, d, e, f, g, h, i, j, k));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l) => firstFunc(secondFunc(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m) => firstFunc(secondFunc(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => firstFunc(secondFunc(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => firstFunc(secondFunc(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        /// <summary>
        /// Composes the function delegate with a second function whose input is the output of the first function.
        /// </summary>
        /// <param name="firstFunc">
        /// The first function delegate to compose.
        /// </param>
        /// <param name="secondFunc">
        /// The second function delegate to compose.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter of <paramref name="secondFunc"/>.
        /// </typeparam>
        /// <typeparam name="TIntermediateResult">
        /// The type of the intermediate return value, which is the return value of <paramref name="secondFunc"/> and the input to <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value, which is also the return value of <paramref name="firstFunc"/>.
        /// </typeparam>
        /// <returns>
        /// A composed function delegate which is the result of applying the result of <paramref name="secondFunc"/> to <paramref name="firstFunc"/>.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Compose<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TIntermediateResult, TResult>(this Func<TIntermediateResult, TResult> firstFunc, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TIntermediateResult> secondFunc)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => firstFunc(secondFunc(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p));
        }

        #endregion
    }
}