#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DecurryExtensionMethod.cs" company="MorseCode Software">
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
    /// Provides an extension method to remove currying, which can be called on a curried function to turn it back into a function
    /// with multiple parameters.
    /// </summary>
    public static class DecurryExtensionMethod
    {
        #region Public Methods and Operators

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with two parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with two parameters.
        /// </returns>
        public static Func<T1, T2, TResult> Decurry<T1, T2, TResult>(this Func<T1, Func<T2, TResult>> func)
        {
            return (a, b) => func(a)(b);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with three parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with three parameters.
        /// </returns>
        public static Func<T1, T2, T3, TResult> Decurry<T1, T2, T3, TResult>(this Func<T1, Func<T2, Func<T3, TResult>>> func)
        {
            return (a, b, c) => func(a)(b)(c);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with four parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with four parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, TResult> Decurry<T1, T2, T3, T4, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> func)
        {
            return (a, b, c, d) => func(a)(b)(c)(d);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with five parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with five parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, TResult> Decurry<T1, T2, T3, T4, T5, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>> func)
        {
            return (a, b, c, d, e) => func(a)(b)(c)(d)(e);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with six parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with six parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, TResult> Decurry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>> func)
        {
            return (a, b, c, d, e, f) => func(a)(b)(c)(d)(e)(f);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with seven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with seven parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, TResult> Decurry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>> func)
        {
            return (a, b, c, d, e, f, g) => func(a)(b)(c)(d)(e)(f)(g);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with eight parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with eight parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Decurry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>> func)
        {
            return (a, b, c, d, e, f, g, h) => func(a)(b)(c)(d)(e)(f)(g)(h);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with nine parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with nine parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Decurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>> func)
        {
            return (a, b, c, d, e, f, g, h, i) => func(a)(b)(c)(d)(e)(f)(g)(h)(i);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with ten parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with ten parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Decurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>> func)
        {
            return (a, b, c, d, e, f, g, h, i, j) => func(a)(b)(c)(d)(e)(f)(g)(h)(i)(j);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with eleven parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with eleven parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Decurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>> func)
        {
            return (a, b, c, d, e, f, g, h, i, j, k) => func(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with twelve parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with twelve parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Decurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>> func)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l) => func(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with thirteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with thirteen parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Decurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>> func)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m) => func(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l)(m);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with fourteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with fourteen parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Decurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>> func)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => func(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l)(m)(n);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with fifteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with fifteen parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Decurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>> func)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => func(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l)(m)(n)(o);
        }

        /// <summary>
        /// Removes currying from the curried function delegate back into a function with sixteen parameters.
        /// </summary>
        /// <param name="func">
        /// The function delegate from which to remove currying.
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
        /// A function with currying removed delegate with sixteen parameters.
        /// </returns>
        public static Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Decurry<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(this Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, Func<T16, TResult>>>>>>>>>>>>>>>> func)
        {
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => func(a)(b)(c)(d)(e)(f)(g)(h)(i)(j)(k)(l)(m)(n)(o)(p);
        }

        #endregion
    }
}