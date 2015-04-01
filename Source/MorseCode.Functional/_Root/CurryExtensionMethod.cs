#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CurryExtensionMethod.cs" company="MorseCode Software">
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
    /// Provides the curry extension method, which can be called on a function with multiple parameters to turn it into a series of curried
    /// functions with one parameter each.
    /// </summary>
    public static class CurryExtensionMethod
    {
        #region Public Methods and Operators

        /// <summary>
        /// Curries the parameters for a function delegate taking two parameters by turning the function
        /// into a series of two functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of two functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, TResult>> Curry<T1, T2, TResult>(this Func<T1, T2, TResult> func)
        {
            return a => b => func(a, b);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking three parameters by turning the function
        /// into a series of three functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of three functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func)
        {
            return a => b => c => func(a, b, c);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking four parameters by turning the function
        /// into a series of four functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of four functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> Curry<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func)
        {
            return a => b => c => d => func(a, b, c, d);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking five parameters by turning the function
        /// into a series of five functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of five functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>> Curry<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func)
        {
            return a => b => c => d => e => func(a, b, c, d, e);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking six parameters by turning the function
        /// into a series of six functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of six functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>> Curry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func)
        {
            return a => b => c => d => e => f => func(a, b, c, d, e, f);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking seven parameters by turning the function
        /// into a series of seven functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of seven functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func)
        {
            return a => b => c => d => e => f => g => func(a, b, c, d, e, f, g);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking eight parameters by turning the function
        /// into a series of eight functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of eight functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func)
        {
            return a => b => c => d => e => f => g => h => func(a, b, c, d, e, f, g, h);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking nine parameters by turning the function
        /// into a series of nine functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of nine functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> func)
        {
            return a => b => c => d => e => f => g => h => i => func(a, b, c, d, e, f, g, h, i);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking ten parameters by turning the function
        /// into a series of ten functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of ten functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> func)
        {
            return a => b => c => d => e => f => g => h => i => j => func(a, b, c, d, e, f, g, h, i, j);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking eleven parameters by turning the function
        /// into a series of eleven functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of eleven functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> func)
        {
            return a => b => c => d => e => f => g => h => i => j => k => func(a, b, c, d, e, f, g, h, i, j, k);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking twelve parameters by turning the function
        /// into a series of twelve functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of twelve functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> func)
        {
            return a => b => c => d => e => f => g => h => i => j => k => l => func(a, b, c, d, e, f, g, h, i, j, k, l);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking thirteen parameters by turning the function
        /// into a series of thirteen functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of thirteen functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> func)
        {
            return a => b => c => d => e => f => g => h => i => j => k => l => m => func(a, b, c, d, e, f, g, h, i, j, k, l, m);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking fourteen parameters by turning the function
        /// into a series of fourteen functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of fourteen functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> func)
        {
            return a => b => c => d => e => f => g => h => i => j => k => l => m => n => func(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking fifteen parameters by turning the function
        /// into a series of fifteen functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of fifteen functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> func)
        {
            return a => b => c => d => e => f => g => h => i => j => k => l => m => n => o => func(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
        }

        /// <summary>
        /// Curries the parameters for a function delegate taking sixteen parameters by turning the function
        /// into a series of sixteen functions with one parameter each.
        /// </summary>
        /// <param name="func">
        /// The function delegate to curry.
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
        /// A curried function delegate which is a series of sixteen functions with one parameter each.
        /// </returns>
        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> func)
        {
            return a => b => c => d => e => f => g => h => i => j => k => l => m => n => o => p => func(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        }

        #endregion
    }
}