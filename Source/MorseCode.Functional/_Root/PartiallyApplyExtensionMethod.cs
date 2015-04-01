#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PartiallyApplyExtensionMethod.cs" company="MorseCode Software">
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
    /// Provides a partial application extension method, which can be called on a function to partially apply some or all of its parameters to
    /// produce a new function delegate.
    /// </summary>
    public static class PartiallyApplyExtensionMethod
    {
        #region Public Methods and Operators

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with one parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, TResult>(this Func<T1, TResult> func, T1 firstArgument)
        {
            return () => func(firstArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with two parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
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
        /// A function delegate with one parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, TResult> PartiallyApply<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 firstArgument)
        {
            return a => func(firstArgument, a);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with two parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
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
        /// A function delegate with no parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return () => func(firstArgument, secondArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with three parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, TResult> PartiallyApply<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 firstArgument)
        {
            return (a, b) => func(firstArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with three parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, TResult> PartiallyApply<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return a => func(firstArgument, secondArgument, a);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with three parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with four parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, TResult> PartiallyApply<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 firstArgument)
        {
            return (a, b, c) => func(firstArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with four parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, TResult> PartiallyApply<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with four parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, TResult> PartiallyApply<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, a);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with four parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with five parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with four parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, T5, TResult> PartiallyApply<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 firstArgument)
        {
            return (a, b, c, d) => func(firstArgument, a, b, c, d);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with five parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, T5, TResult> PartiallyApply<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b, c) => func(firstArgument, secondArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with five parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, T5, TResult> PartiallyApply<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, thirdArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with five parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T5, TResult> PartiallyApply<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, fourthArgument, a);
        }

        /// <summary>
        /// Partially applies the first five parameters for a function delegate with five parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first five parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with six parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with five parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, T5, T6, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 firstArgument)
        {
            return (a, b, c, d, e) => func(firstArgument, a, b, c, d, e);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with six parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with four parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, T5, T6, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b, c, d) => func(firstArgument, secondArgument, a, b, c, d);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with six parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, T5, T6, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return (a, b, c) => func(firstArgument, secondArgument, thirdArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with six parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T5, T6, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first five parameters for a function delegate with six parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first five parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T6, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, a);
        }

        /// <summary>
        /// Partially applies the first six parameters for a function delegate with six parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first six parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with seven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with six parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, T5, T6, T7, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 firstArgument)
        {
            return (a, b, c, d, e, f) => func(firstArgument, a, b, c, d, e, f);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with seven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with five parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, T5, T6, T7, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b, c, d, e) => func(firstArgument, secondArgument, a, b, c, d, e);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with seven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with four parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, T5, T6, T7, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return (a, b, c, d) => func(firstArgument, secondArgument, thirdArgument, a, b, c, d);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with seven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T5, T6, T7, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return (a, b, c) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first five parameters for a function delegate with seven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first five parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T6, T7, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first six parameters for a function delegate with seven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first six parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T7, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, a);
        }

        /// <summary>
        /// Partially applies the first seven parameters for a function delegate with seven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first seven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with eight parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with seven parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 firstArgument)
        {
            return (a, b, c, d, e, f, g) => func(firstArgument, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with eight parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with six parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, T5, T6, T7, T8, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b, c, d, e, f) => func(firstArgument, secondArgument, a, b, c, d, e, f);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with eight parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with five parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, T5, T6, T7, T8, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return (a, b, c, d, e) => func(firstArgument, secondArgument, thirdArgument, a, b, c, d, e);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with eight parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with four parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T5, T6, T7, T8, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return (a, b, c, d) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, a, b, c, d);
        }

        /// <summary>
        /// Partially applies the first five parameters for a function delegate with eight parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first five parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T6, T7, T8, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument)
        {
            return (a, b, c) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first six parameters for a function delegate with eight parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first six parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T7, T8, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first seven parameters for a function delegate with eight parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first seven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T8, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, a);
        }

        /// <summary>
        /// Partially applies the first eight parameters for a function delegate with eight parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first eight parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with nine parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eight parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 firstArgument)
        {
            return (a, b, c, d, e, f, g, h) => func(firstArgument, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with nine parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with seven parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b, c, d, e, f, g) => func(firstArgument, secondArgument, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with nine parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with six parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, T5, T6, T7, T8, T9, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return (a, b, c, d, e, f) => func(firstArgument, secondArgument, thirdArgument, a, b, c, d, e, f);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with nine parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with five parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T5, T6, T7, T8, T9, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return (a, b, c, d, e) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, a, b, c, d, e);
        }

        /// <summary>
        /// Partially applies the first five parameters for a function delegate with nine parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with four parameters which is a result of
        /// partially applying the first five parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T6, T7, T8, T9, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument)
        {
            return (a, b, c, d) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, a, b, c, d);
        }

        /// <summary>
        /// Partially applies the first six parameters for a function delegate with nine parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first six parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T7, T8, T9, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument)
        {
            return (a, b, c) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first seven parameters for a function delegate with nine parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first seven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T8, T9, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first eight parameters for a function delegate with nine parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first eight parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T9, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, a);
        }

        /// <summary>
        /// Partially applies the first nine parameters for a function delegate with nine parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first nine parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with ten parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with nine parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 firstArgument)
        {
            return (a, b, c, d, e, f, g, h, i) => func(firstArgument, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with ten parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eight parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b, c, d, e, f, g, h) => func(firstArgument, secondArgument, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with ten parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with seven parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return (a, b, c, d, e, f, g) => func(firstArgument, secondArgument, thirdArgument, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with ten parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with six parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T5, T6, T7, T8, T9, T10, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return (a, b, c, d, e, f) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, a, b, c, d, e, f);
        }

        /// <summary>
        /// Partially applies the first five parameters for a function delegate with ten parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with five parameters which is a result of
        /// partially applying the first five parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T6, T7, T8, T9, T10, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument)
        {
            return (a, b, c, d, e) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, a, b, c, d, e);
        }

        /// <summary>
        /// Partially applies the first six parameters for a function delegate with ten parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with four parameters which is a result of
        /// partially applying the first six parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T7, T8, T9, T10, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument)
        {
            return (a, b, c, d) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, a, b, c, d);
        }

        /// <summary>
        /// Partially applies the first seven parameters for a function delegate with ten parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first seven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T8, T9, T10, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument)
        {
            return (a, b, c) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first eight parameters for a function delegate with ten parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first eight parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T9, T10, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first nine parameters for a function delegate with ten parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first nine parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T10, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, a);
        }

        /// <summary>
        /// Partially applies the first ten parameters for a function delegate with ten parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first ten parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with eleven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with ten parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 firstArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j) => func(firstArgument, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with eleven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with nine parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b, c, d, e, f, g, h, i) => func(firstArgument, secondArgument, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with eleven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eight parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return (a, b, c, d, e, f, g, h) => func(firstArgument, secondArgument, thirdArgument, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with eleven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with seven parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T5, T6, T7, T8, T9, T10, T11, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return (a, b, c, d, e, f, g) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Partially applies the first five parameters for a function delegate with eleven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with six parameters which is a result of
        /// partially applying the first five parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T6, T7, T8, T9, T10, T11, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument)
        {
            return (a, b, c, d, e, f) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, a, b, c, d, e, f);
        }

        /// <summary>
        /// Partially applies the first six parameters for a function delegate with eleven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with five parameters which is a result of
        /// partially applying the first six parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T7, T8, T9, T10, T11, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument)
        {
            return (a, b, c, d, e) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, a, b, c, d, e);
        }

        /// <summary>
        /// Partially applies the first seven parameters for a function delegate with eleven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with four parameters which is a result of
        /// partially applying the first seven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T8, T9, T10, T11, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument)
        {
            return (a, b, c, d) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, a, b, c, d);
        }

        /// <summary>
        /// Partially applies the first eight parameters for a function delegate with eleven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first eight parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T9, T10, T11, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument)
        {
            return (a, b, c) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first nine parameters for a function delegate with eleven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first nine parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T10, T11, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first ten parameters for a function delegate with eleven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first ten parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T11, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, a);
        }

        /// <summary>
        /// Partially applies the first eleven parameters for a function delegate with eleven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first eleven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eleven parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 firstArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k) => func(firstArgument, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with ten parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j) => func(firstArgument, secondArgument, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with nine parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return (a, b, c, d, e, f, g, h, i) => func(firstArgument, secondArgument, thirdArgument, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eight parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return (a, b, c, d, e, f, g, h) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Partially applies the first five parameters for a function delegate with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with seven parameters which is a result of
        /// partially applying the first five parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T6, T7, T8, T9, T10, T11, T12, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument)
        {
            return (a, b, c, d, e, f, g) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Partially applies the first six parameters for a function delegate with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with six parameters which is a result of
        /// partially applying the first six parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T7, T8, T9, T10, T11, T12, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument)
        {
            return (a, b, c, d, e, f) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, a, b, c, d, e, f);
        }

        /// <summary>
        /// Partially applies the first seven parameters for a function delegate with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with five parameters which is a result of
        /// partially applying the first seven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T8, T9, T10, T11, T12, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument)
        {
            return (a, b, c, d, e) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, a, b, c, d, e);
        }

        /// <summary>
        /// Partially applies the first eight parameters for a function delegate with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with four parameters which is a result of
        /// partially applying the first eight parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T9, T10, T11, T12, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument)
        {
            return (a, b, c, d) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, a, b, c, d);
        }

        /// <summary>
        /// Partially applies the first nine parameters for a function delegate with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first nine parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T10, T11, T12, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument)
        {
            return (a, b, c) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first ten parameters for a function delegate with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first ten parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T11, T12, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first eleven parameters for a function delegate with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first eleven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T12, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, a);
        }

        /// <summary>
        /// Partially applies the first twelve parameters for a function delegate with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first twelve parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with twelve parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l) => func(firstArgument, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eleven parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k) => func(firstArgument, secondArgument, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with ten parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j) => func(firstArgument, secondArgument, thirdArgument, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with nine parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return (a, b, c, d, e, f, g, h, i) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Partially applies the first five parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eight parameters which is a result of
        /// partially applying the first five parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument)
        {
            return (a, b, c, d, e, f, g, h) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Partially applies the first six parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with seven parameters which is a result of
        /// partially applying the first six parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T7, T8, T9, T10, T11, T12, T13, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument)
        {
            return (a, b, c, d, e, f, g) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Partially applies the first seven parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with six parameters which is a result of
        /// partially applying the first seven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T8, T9, T10, T11, T12, T13, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument)
        {
            return (a, b, c, d, e, f) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, a, b, c, d, e, f);
        }

        /// <summary>
        /// Partially applies the first eight parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with five parameters which is a result of
        /// partially applying the first eight parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T9, T10, T11, T12, T13, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument)
        {
            return (a, b, c, d, e) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, a, b, c, d, e);
        }

        /// <summary>
        /// Partially applies the first nine parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with four parameters which is a result of
        /// partially applying the first nine parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T10, T11, T12, T13, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument)
        {
            return (a, b, c, d) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, a, b, c, d);
        }

        /// <summary>
        /// Partially applies the first ten parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first ten parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T11, T12, T13, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument)
        {
            return (a, b, c) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first eleven parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first eleven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T12, T13, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first twelve parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first twelve parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T13, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, a);
        }

        /// <summary>
        /// Partially applies the first thirteen parameters for a function delegate with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <param name="thirteenthArgument">
        /// The value of the thirteenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first thirteen parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument, T13 thirteenthArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, thirteenthArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with thirteen parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m) => func(firstArgument, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with twelve parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l) => func(firstArgument, secondArgument, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eleven parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k) => func(firstArgument, secondArgument, thirdArgument, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with ten parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Partially applies the first five parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with nine parameters which is a result of
        /// partially applying the first five parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument)
        {
            return (a, b, c, d, e, f, g, h, i) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Partially applies the first six parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eight parameters which is a result of
        /// partially applying the first six parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument)
        {
            return (a, b, c, d, e, f, g, h) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Partially applies the first seven parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with seven parameters which is a result of
        /// partially applying the first seven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T8, T9, T10, T11, T12, T13, T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument)
        {
            return (a, b, c, d, e, f, g) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Partially applies the first eight parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with six parameters which is a result of
        /// partially applying the first eight parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T9, T10, T11, T12, T13, T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument)
        {
            return (a, b, c, d, e, f) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, a, b, c, d, e, f);
        }

        /// <summary>
        /// Partially applies the first nine parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with five parameters which is a result of
        /// partially applying the first nine parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T10, T11, T12, T13, T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument)
        {
            return (a, b, c, d, e) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, a, b, c, d, e);
        }

        /// <summary>
        /// Partially applies the first ten parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with four parameters which is a result of
        /// partially applying the first ten parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T11, T12, T13, T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument)
        {
            return (a, b, c, d) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, a, b, c, d);
        }

        /// <summary>
        /// Partially applies the first eleven parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first eleven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T12, T13, T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument)
        {
            return (a, b, c) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first twelve parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first twelve parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T13, T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first thirteen parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <param name="thirteenthArgument">
        /// The value of the thirteenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first thirteen parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T14, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument, T13 thirteenthArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, thirteenthArgument, a);
        }

        /// <summary>
        /// Partially applies the first fourteen parameters for a function delegate with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <param name="thirteenthArgument">
        /// The value of the thirteenth parameter to partially apply.
        /// </param>
        /// <param name="fourteenthArgument">
        /// The value of the fourteenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first fourteen parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument, T13 thirteenthArgument, T14 fourteenthArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, thirteenthArgument, fourteenthArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with fourteen parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => func(firstArgument, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with thirteen parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m) => func(firstArgument, secondArgument, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with twelve parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l) => func(firstArgument, secondArgument, thirdArgument, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eleven parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Partially applies the first five parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with ten parameters which is a result of
        /// partially applying the first five parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Partially applies the first six parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with nine parameters which is a result of
        /// partially applying the first six parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument)
        {
            return (a, b, c, d, e, f, g, h, i) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Partially applies the first seven parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eight parameters which is a result of
        /// partially applying the first seven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument)
        {
            return (a, b, c, d, e, f, g, h) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Partially applies the first eight parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with seven parameters which is a result of
        /// partially applying the first eight parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T9, T10, T11, T12, T13, T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument)
        {
            return (a, b, c, d, e, f, g) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Partially applies the first nine parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with six parameters which is a result of
        /// partially applying the first nine parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T10, T11, T12, T13, T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument)
        {
            return (a, b, c, d, e, f) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, a, b, c, d, e, f);
        }

        /// <summary>
        /// Partially applies the first ten parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with five parameters which is a result of
        /// partially applying the first ten parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T11, T12, T13, T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument)
        {
            return (a, b, c, d, e) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, a, b, c, d, e);
        }

        /// <summary>
        /// Partially applies the first eleven parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with four parameters which is a result of
        /// partially applying the first eleven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T12, T13, T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument)
        {
            return (a, b, c, d) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, a, b, c, d);
        }

        /// <summary>
        /// Partially applies the first twelve parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first twelve parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T13, T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument)
        {
            return (a, b, c) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first thirteen parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <param name="thirteenthArgument">
        /// The value of the thirteenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first thirteen parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T14, T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument, T13 thirteenthArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, thirteenthArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first fourteen parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <param name="thirteenthArgument">
        /// The value of the thirteenth parameter to partially apply.
        /// </param>
        /// <param name="fourteenthArgument">
        /// The value of the fourteenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first fourteen parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T15, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument, T13 thirteenthArgument, T14 fourteenthArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, thirteenthArgument, fourteenthArgument, a);
        }

        /// <summary>
        /// Partially applies the first fifteen parameters for a function delegate with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <param name="thirteenthArgument">
        /// The value of the thirteenth parameter to partially apply.
        /// </param>
        /// <param name="fourteenthArgument">
        /// The value of the fourteenth parameter to partially apply.
        /// </param>
        /// <param name="fifteenthArgument">
        /// The value of the fifteenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first fifteen parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument, T13 thirteenthArgument, T14 fourteenthArgument, T15 fifteenthArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, thirteenthArgument, fourteenthArgument, fifteenthArgument);
        }

        /// <summary>
        /// Partially applies the first one parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with fifteen parameters which is a result of
        /// partially applying the first one parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => func(firstArgument, a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }

        /// <summary>
        /// Partially applies the first two parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with fourteen parameters which is a result of
        /// partially applying the first two parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => func(firstArgument, secondArgument, a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        /// <summary>
        /// Partially applies the first three parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with thirteen parameters which is a result of
        /// partially applying the first three parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m) => func(firstArgument, secondArgument, thirdArgument, a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        /// Partially applies the first four parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with twelve parameters which is a result of
        /// partially applying the first four parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Partially applies the first five parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eleven parameters which is a result of
        /// partially applying the first five parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j, k) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Partially applies the first six parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with ten parameters which is a result of
        /// partially applying the first six parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument)
        {
            return (a, b, c, d, e, f, g, h, i, j) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Partially applies the first seven parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with nine parameters which is a result of
        /// partially applying the first seven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument)
        {
            return (a, b, c, d, e, f, g, h, i) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Partially applies the first eight parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with eight parameters which is a result of
        /// partially applying the first eight parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument)
        {
            return (a, b, c, d, e, f, g, h) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Partially applies the first nine parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with seven parameters which is a result of
        /// partially applying the first nine parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T10, T11, T12, T13, T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument)
        {
            return (a, b, c, d, e, f, g) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Partially applies the first ten parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with six parameters which is a result of
        /// partially applying the first ten parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T11, T12, T13, T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument)
        {
            return (a, b, c, d, e, f) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, a, b, c, d, e, f);
        }

        /// <summary>
        /// Partially applies the first eleven parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with five parameters which is a result of
        /// partially applying the first eleven parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T12, T13, T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument)
        {
            return (a, b, c, d, e) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, a, b, c, d, e);
        }

        /// <summary>
        /// Partially applies the first twelve parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with four parameters which is a result of
        /// partially applying the first twelve parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T13, T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument)
        {
            return (a, b, c, d) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, a, b, c, d);
        }

        /// <summary>
        /// Partially applies the first thirteen parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <param name="thirteenthArgument">
        /// The value of the thirteenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with three parameters which is a result of
        /// partially applying the first thirteen parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T14, T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument, T13 thirteenthArgument)
        {
            return (a, b, c) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, thirteenthArgument, a, b, c);
        }

        /// <summary>
        /// Partially applies the first fourteen parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <param name="thirteenthArgument">
        /// The value of the thirteenth parameter to partially apply.
        /// </param>
        /// <param name="fourteenthArgument">
        /// The value of the fourteenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with two parameters which is a result of
        /// partially applying the first fourteen parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T15, T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument, T13 thirteenthArgument, T14 fourteenthArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, thirteenthArgument, fourteenthArgument, a, b);
        }

        /// <summary>
        /// Partially applies the first fifteen parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <param name="thirteenthArgument">
        /// The value of the thirteenth parameter to partially apply.
        /// </param>
        /// <param name="fourteenthArgument">
        /// The value of the fourteenth parameter to partially apply.
        /// </param>
        /// <param name="fifteenthArgument">
        /// The value of the fifteenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with one parameters which is a result of
        /// partially applying the first fifteen parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<T16, TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument, T13 thirteenthArgument, T14 fourteenthArgument, T15 fifteenthArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, thirteenthArgument, fourteenthArgument, fifteenthArgument, a);
        }

        /// <summary>
        /// Partially applies the first sixteen parameters for a function delegate with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate to which to partially apply parameters.
        /// </param>
        /// <param name="firstArgument">
        /// The value of the first parameter to partially apply.
        /// </param>
        /// <param name="secondArgument">
        /// The value of the second parameter to partially apply.
        /// </param>
        /// <param name="thirdArgument">
        /// The value of the third parameter to partially apply.
        /// </param>
        /// <param name="fourthArgument">
        /// The value of the fourth parameter to partially apply.
        /// </param>
        /// <param name="fifthArgument">
        /// The value of the fifth parameter to partially apply.
        /// </param>
        /// <param name="sixthArgument">
        /// The value of the sixth parameter to partially apply.
        /// </param>
        /// <param name="seventhArgument">
        /// The value of the seventh parameter to partially apply.
        /// </param>
        /// <param name="eighthArgument">
        /// The value of the eighth parameter to partially apply.
        /// </param>
        /// <param name="ninthArgument">
        /// The value of the ninth parameter to partially apply.
        /// </param>
        /// <param name="tenthArgument">
        /// The value of the tenth parameter to partially apply.
        /// </param>
        /// <param name="eleventhArgument">
        /// The value of the eleventh parameter to partially apply.
        /// </param>
        /// <param name="twelfthArgument">
        /// The value of the twelfth parameter to partially apply.
        /// </param>
        /// <param name="thirteenthArgument">
        /// The value of the thirteenth parameter to partially apply.
        /// </param>
        /// <param name="fourteenthArgument">
        /// The value of the fourteenth parameter to partially apply.
        /// </param>
        /// <param name="fifteenthArgument">
        /// The value of the fifteenth parameter to partially apply.
        /// </param>
        /// <param name="sixteenthArgument">
        /// The value of the sixteenth parameter to partially apply.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first parameter.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second parameter.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third parameter.
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth parameter.
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth parameter.
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth parameter.
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh parameter.
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth parameter.
        /// </typeparam>
        /// <typeparam name="T9">
        /// The type of the ninth parameter.
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth parameter.
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh parameter.
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth parameter.
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth parameter.
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth parameter.
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth parameter.
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth parameter.
        /// </typeparam>
        /// <typeparam name="TResult">
        /// The type of the return value.
        /// </typeparam>
        /// <returns>
        /// A function delegate with no parameters which is a result of
        /// partially applying the first sixteen parameters to <paramref name="func"/>.
        /// </returns>
        public static Func<TResult> PartiallyApply<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument, T5 fifthArgument, T6 sixthArgument, T7 seventhArgument, T8 eighthArgument, T9 ninthArgument, T10 tenthArgument, T11 eleventhArgument, T12 twelfthArgument, T13 thirteenthArgument, T14 fourteenthArgument, T15 fifteenthArgument, T16 sixteenthArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument, fifthArgument, sixthArgument, seventhArgument, eighthArgument, ninthArgument, tenthArgument, eleventhArgument, twelfthArgument, thirteenthArgument, fourteenthArgument, fifteenthArgument, sixteenthArgument);
        }

        #endregion
    }
}