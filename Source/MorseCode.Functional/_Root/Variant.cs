#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Variant.cs" company="MorseCode Software">
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
    /// A factory class for creating variant (or discriminated union) instances.
    /// </summary>
    public static class Variant
    {
        #region Public Methods and Operators

        /// <summary>
        /// Creates a variant (or discriminated union) with two possible values with a common type
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T">
        /// The common type all possible values of the variant (or discriminated union) inherit from or implement.
        /// </typeparam>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2> FirstWithCommon<T, T1, T2>(T1 value)
            where T1 : T
            where T2 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2>>() != null);

            return new VariantWithCommonClassWithFirst<T, T1, T2>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with two possible values with a common type
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T">
        /// The common type all possible values of the variant (or discriminated union) inherit from or implement.
        /// </typeparam>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2> SecondWithCommon<T, T1, T2>(T2 value)
            where T1 : T
            where T2 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2>>() != null);

            return new VariantWithCommonClassWithSecond<T, T1, T2>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with three possible values with a common type
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3> FirstWithCommon<T, T1, T2, T3>(T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3>>() != null);

            return new VariantWithCommonClassWithFirst<T, T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with three possible values with a common type
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3> SecondWithCommon<T, T1, T2, T3>(T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3>>() != null);

            return new VariantWithCommonClassWithSecond<T, T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with three possible values with a common type
        /// holding a value of the third possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3> ThirdWithCommon<T, T1, T2, T3>(T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3>>() != null);

            return new VariantWithCommonClassWithThird<T, T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with four possible values with a common type
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4> FirstWithCommon<T, T1, T2, T3, T4>(T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4>>() != null);

            return new VariantWithCommonClassWithFirst<T, T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with four possible values with a common type
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4> SecondWithCommon<T, T1, T2, T3, T4>(T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4>>() != null);

            return new VariantWithCommonClassWithSecond<T, T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with four possible values with a common type
        /// holding a value of the third possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4> ThirdWithCommon<T, T1, T2, T3, T4>(T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4>>() != null);

            return new VariantWithCommonClassWithThird<T, T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with four possible values with a common type
        /// holding a value of the fourth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4> FourthWithCommon<T, T1, T2, T3, T4>(T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4>>() != null);

            return new VariantWithCommonClassWithFourth<T, T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with five possible values with a common type
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5> FirstWithCommon<T, T1, T2, T3, T4, T5>(T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5>>() != null);

            return new VariantWithCommonClassWithFirst<T, T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with five possible values with a common type
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5> SecondWithCommon<T, T1, T2, T3, T4, T5>(T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5>>() != null);

            return new VariantWithCommonClassWithSecond<T, T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with five possible values with a common type
        /// holding a value of the third possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5> ThirdWithCommon<T, T1, T2, T3, T4, T5>(T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5>>() != null);

            return new VariantWithCommonClassWithThird<T, T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with five possible values with a common type
        /// holding a value of the fourth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5> FourthWithCommon<T, T1, T2, T3, T4, T5>(T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5>>() != null);

            return new VariantWithCommonClassWithFourth<T, T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with five possible values with a common type
        /// holding a value of the fifth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5> FifthWithCommon<T, T1, T2, T3, T4, T5>(T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5>>() != null);

            return new VariantWithCommonClassWithFifth<T, T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with six possible values with a common type
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> FirstWithCommon<T, T1, T2, T3, T4, T5, T6>(T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>>() != null);

            return new VariantWithCommonClassWithFirst<T, T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with six possible values with a common type
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> SecondWithCommon<T, T1, T2, T3, T4, T5, T6>(T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>>() != null);

            return new VariantWithCommonClassWithSecond<T, T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with six possible values with a common type
        /// holding a value of the third possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> ThirdWithCommon<T, T1, T2, T3, T4, T5, T6>(T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>>() != null);

            return new VariantWithCommonClassWithThird<T, T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with six possible values with a common type
        /// holding a value of the fourth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> FourthWithCommon<T, T1, T2, T3, T4, T5, T6>(T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>>() != null);

            return new VariantWithCommonClassWithFourth<T, T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with six possible values with a common type
        /// holding a value of the fifth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> FifthWithCommon<T, T1, T2, T3, T4, T5, T6>(T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>>() != null);

            return new VariantWithCommonClassWithFifth<T, T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with six possible values with a common type
        /// holding a value of the sixth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> SixthWithCommon<T, T1, T2, T3, T4, T5, T6>(T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>>() != null);

            return new VariantWithCommonClassWithSixth<T, T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> FirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantWithCommonClassWithFirst<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> SecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantWithCommonClassWithSecond<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the third possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> ThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantWithCommonClassWithThird<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the fourth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> FourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantWithCommonClassWithFourth<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the fifth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> FifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantWithCommonClassWithFifth<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the sixth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> SixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantWithCommonClassWithSixth<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the seventh possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> SeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(T7 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantWithCommonClassWithSeventh<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> FirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantWithCommonClassWithFirst<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> SecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantWithCommonClassWithSecond<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the third possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> ThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantWithCommonClassWithThird<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the fourth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> FourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantWithCommonClassWithFourth<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the fifth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> FifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantWithCommonClassWithFifth<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the sixth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> SixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantWithCommonClassWithSixth<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the seventh possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> SeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(T7 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantWithCommonClassWithSeventh<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the eighth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
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
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> EighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(T8 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantWithCommonClassWithEighth<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with two possible values
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2> First<T1, T2>(T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2>>() != null);

            return new VariantClassWithFirst<T1, T2>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with two possible values
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2> Second<T1, T2>(T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2>>() != null);

            return new VariantClassWithSecond<T1, T2>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with three possible values
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3> First<T1, T2, T3>(T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            return new VariantClassWithFirst<T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with three possible values
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3> Second<T1, T2, T3>(T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            return new VariantClassWithSecond<T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with three possible values
        /// holding a value of the third possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3> Third<T1, T2, T3>(T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            return new VariantClassWithThird<T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with four possible values
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> First<T1, T2, T3, T4>(T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            return new VariantClassWithFirst<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with four possible values
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Second<T1, T2, T3, T4>(T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            return new VariantClassWithSecond<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with four possible values
        /// holding a value of the third possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Third<T1, T2, T3, T4>(T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            return new VariantClassWithThird<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with four possible values
        /// holding a value of the fourth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Fourth<T1, T2, T3, T4>(T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            return new VariantClassWithFourth<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with five possible values
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5> First<T1, T2, T3, T4, T5>(T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5>>() != null);

            return new VariantClassWithFirst<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with five possible values
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5> Second<T1, T2, T3, T4, T5>(T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5>>() != null);

            return new VariantClassWithSecond<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with five possible values
        /// holding a value of the third possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5> Third<T1, T2, T3, T4, T5>(T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5>>() != null);

            return new VariantClassWithThird<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with five possible values
        /// holding a value of the fourth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5> Fourth<T1, T2, T3, T4, T5>(T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5>>() != null);

            return new VariantClassWithFourth<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with five possible values
        /// holding a value of the fifth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5> Fifth<T1, T2, T3, T4, T5>(T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5>>() != null);

            return new VariantClassWithFifth<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with six possible values
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6> First<T1, T2, T3, T4, T5, T6>(T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6>>() != null);

            return new VariantClassWithFirst<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with six possible values
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6> Second<T1, T2, T3, T4, T5, T6>(T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6>>() != null);

            return new VariantClassWithSecond<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with six possible values
        /// holding a value of the third possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6> Third<T1, T2, T3, T4, T5, T6>(T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6>>() != null);

            return new VariantClassWithThird<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with six possible values
        /// holding a value of the fourth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6> Fourth<T1, T2, T3, T4, T5, T6>(T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6>>() != null);

            return new VariantClassWithFourth<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with six possible values
        /// holding a value of the fifth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6> Fifth<T1, T2, T3, T4, T5, T6>(T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6>>() != null);

            return new VariantClassWithFifth<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with six possible values
        /// holding a value of the sixth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6> Sixth<T1, T2, T3, T4, T5, T6>(T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6>>() != null);

            return new VariantClassWithSixth<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> First<T1, T2, T3, T4, T5, T6, T7>(T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantClassWithFirst<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> Second<T1, T2, T3, T4, T5, T6, T7>(T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantClassWithSecond<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values
        /// holding a value of the third possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> Third<T1, T2, T3, T4, T5, T6, T7>(T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantClassWithThird<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values
        /// holding a value of the fourth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> Fourth<T1, T2, T3, T4, T5, T6, T7>(T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantClassWithFourth<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values
        /// holding a value of the fifth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> Fifth<T1, T2, T3, T4, T5, T6, T7>(T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantClassWithFifth<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values
        /// holding a value of the sixth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> Sixth<T1, T2, T3, T4, T5, T6, T7>(T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantClassWithSixth<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with seven possible values
        /// holding a value of the seventh possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> Seventh<T1, T2, T3, T4, T5, T6, T7>(T7 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return new VariantClassWithSeventh<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values
        /// holding a value of the first possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> First<T1, T2, T3, T4, T5, T6, T7, T8>(T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantClassWithFirst<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values
        /// holding a value of the second possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> Second<T1, T2, T3, T4, T5, T6, T7, T8>(T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantClassWithSecond<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values
        /// holding a value of the third possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> Third<T1, T2, T3, T4, T5, T6, T7, T8>(T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantClassWithThird<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values
        /// holding a value of the fourth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> Fourth<T1, T2, T3, T4, T5, T6, T7, T8>(T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantClassWithFourth<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values
        /// holding a value of the fifth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> Fifth<T1, T2, T3, T4, T5, T6, T7, T8>(T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantClassWithFifth<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values
        /// holding a value of the sixth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> Sixth<T1, T2, T3, T4, T5, T6, T7, T8>(T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantClassWithSixth<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values
        /// holding a value of the seventh possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> Seventh<T1, T2, T3, T4, T5, T6, T7, T8>(T7 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantClassWithSeventh<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a variant (or discriminated union) with eight possible values
        /// holding a value of the eighth possible variant value.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T3">
        /// The type of the third possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T4">
        /// The type of the fourth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T5">
        /// The type of the fifth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T6">
        /// The type of the sixth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T7">
        /// The type of the seventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T8">
        /// The type of the eighth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> Eighth<T1, T2, T3, T4, T5, T6, T7, T8>(T8 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return new VariantClassWithEighth<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        #endregion

        private class VariantWithCommonClassWithFirst<T, T1, T2> : IVariantWithCommon<T, T1, T2>
            where T1 : T
            where T2 : T
        {
            #region Fields

            private readonly T1 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFirst(T1 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2>.Match(Action<T1> first, Action<T2> second)
            {
                first(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second)
            {
                return first(this.value);
            }

            void IVariantWithCommon<T, T1, T2>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second)
            {
                if (first != null)
                {
                    first(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second)
            {
                if (first != null)
                {
                    return first(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithSecond<T, T1, T2> : IVariantWithCommon<T, T1, T2>
            where T1 : T
            where T2 : T
        {
            #region Fields

            private readonly T2 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithSecond(T2 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2>.Match(Action<T1> first, Action<T2> second)
            {
                second(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second)
            {
                return second(this.value);
            }

            void IVariantWithCommon<T, T1, T2>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second)
            {
                if (second != null)
                {
                    second(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second)
            {
                if (second != null)
                {
                    return second(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFirst<T, T1, T2, T3> : IVariantWithCommon<T, T1, T2, T3>
            where T1 : T
            where T2 : T
            where T3 : T
        {
            #region Fields

            private readonly T1 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFirst(T1 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3>.Match(Action<T1> first, Action<T2> second, Action<T3> third)
            {
                first(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third)
            {
                return first(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third)
            {
                if (first != null)
                {
                    first(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third)
            {
                if (first != null)
                {
                    return first(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithSecond<T, T1, T2, T3> : IVariantWithCommon<T, T1, T2, T3>
            where T1 : T
            where T2 : T
            where T3 : T
        {
            #region Fields

            private readonly T2 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithSecond(T2 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3>.Match(Action<T1> first, Action<T2> second, Action<T3> third)
            {
                second(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third)
            {
                return second(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third)
            {
                if (second != null)
                {
                    second(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third)
            {
                if (second != null)
                {
                    return second(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithThird<T, T1, T2, T3> : IVariantWithCommon<T, T1, T2, T3>
            where T1 : T
            where T2 : T
            where T3 : T
        {
            #region Fields

            private readonly T3 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithThird(T3 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3>.Match(Action<T1> first, Action<T2> second, Action<T3> third)
            {
                third(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third)
            {
                return third(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third)
            {
                if (third != null)
                {
                    third(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third)
            {
                if (third != null)
                {
                    return third(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFirst<T, T1, T2, T3, T4> : IVariantWithCommon<T, T1, T2, T3, T4>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            #region Fields

            private readonly T1 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFirst(T1 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth)
            {
                first(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth)
            {
                return first(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth)
            {
                if (first != null)
                {
                    first(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth)
            {
                if (first != null)
                {
                    return first(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithSecond<T, T1, T2, T3, T4> : IVariantWithCommon<T, T1, T2, T3, T4>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            #region Fields

            private readonly T2 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithSecond(T2 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth)
            {
                second(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth)
            {
                return second(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth)
            {
                if (second != null)
                {
                    second(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth)
            {
                if (second != null)
                {
                    return second(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithThird<T, T1, T2, T3, T4> : IVariantWithCommon<T, T1, T2, T3, T4>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            #region Fields

            private readonly T3 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithThird(T3 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth)
            {
                third(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth)
            {
                return third(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth)
            {
                if (third != null)
                {
                    third(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth)
            {
                if (third != null)
                {
                    return third(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFourth<T, T1, T2, T3, T4> : IVariantWithCommon<T, T1, T2, T3, T4>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            #region Fields

            private readonly T4 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFourth(T4 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth)
            {
                fourth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth)
            {
                return fourth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth)
            {
                if (fourth != null)
                {
                    fourth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth)
            {
                if (fourth != null)
                {
                    return fourth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFirst<T, T1, T2, T3, T4, T5> : IVariantWithCommon<T, T1, T2, T3, T4, T5>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            #region Fields

            private readonly T1 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFirst(T1 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth)
            {
                first(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth)
            {
                return first(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth)
            {
                if (first != null)
                {
                    first(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth)
            {
                if (first != null)
                {
                    return first(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithSecond<T, T1, T2, T3, T4, T5> : IVariantWithCommon<T, T1, T2, T3, T4, T5>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            #region Fields

            private readonly T2 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithSecond(T2 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth)
            {
                second(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth)
            {
                return second(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth)
            {
                if (second != null)
                {
                    second(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth)
            {
                if (second != null)
                {
                    return second(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithThird<T, T1, T2, T3, T4, T5> : IVariantWithCommon<T, T1, T2, T3, T4, T5>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            #region Fields

            private readonly T3 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithThird(T3 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth)
            {
                third(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth)
            {
                return third(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth)
            {
                if (third != null)
                {
                    third(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth)
            {
                if (third != null)
                {
                    return third(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFourth<T, T1, T2, T3, T4, T5> : IVariantWithCommon<T, T1, T2, T3, T4, T5>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            #region Fields

            private readonly T4 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFourth(T4 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth)
            {
                fourth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth)
            {
                return fourth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth)
            {
                if (fourth != null)
                {
                    fourth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth)
            {
                if (fourth != null)
                {
                    return fourth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFifth<T, T1, T2, T3, T4, T5> : IVariantWithCommon<T, T1, T2, T3, T4, T5>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            #region Fields

            private readonly T5 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFifth(T5 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth)
            {
                fifth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth)
            {
                return fifth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth)
            {
                if (fifth != null)
                {
                    fifth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth)
            {
                if (fifth != null)
                {
                    return fifth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFirst<T, T1, T2, T3, T4, T5, T6> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            #region Fields

            private readonly T1 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFirst(T1 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            {
                first(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth)
            {
                return first(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            {
                if (first != null)
                {
                    first(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth)
            {
                if (first != null)
                {
                    return first(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithSecond<T, T1, T2, T3, T4, T5, T6> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            #region Fields

            private readonly T2 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithSecond(T2 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            {
                second(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth)
            {
                return second(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            {
                if (second != null)
                {
                    second(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth)
            {
                if (second != null)
                {
                    return second(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithThird<T, T1, T2, T3, T4, T5, T6> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            #region Fields

            private readonly T3 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithThird(T3 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            {
                third(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth)
            {
                return third(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            {
                if (third != null)
                {
                    third(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth)
            {
                if (third != null)
                {
                    return third(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFourth<T, T1, T2, T3, T4, T5, T6> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            #region Fields

            private readonly T4 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFourth(T4 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            {
                fourth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth)
            {
                return fourth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            {
                if (fourth != null)
                {
                    fourth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth)
            {
                if (fourth != null)
                {
                    return fourth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFifth<T, T1, T2, T3, T4, T5, T6> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            #region Fields

            private readonly T5 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFifth(T5 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            {
                fifth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth)
            {
                return fifth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            {
                if (fifth != null)
                {
                    fifth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth)
            {
                if (fifth != null)
                {
                    return fifth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithSixth<T, T1, T2, T3, T4, T5, T6> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            #region Fields

            private readonly T6 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithSixth(T6 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            {
                sixth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth)
            {
                return sixth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth)
            {
                if (sixth != null)
                {
                    sixth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth)
            {
                if (sixth != null)
                {
                    return sixth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFirst<T, T1, T2, T3, T4, T5, T6, T7> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            #region Fields

            private readonly T1 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFirst(T1 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                first(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                return first(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                if (first != null)
                {
                    first(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                if (first != null)
                {
                    return first(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithSecond<T, T1, T2, T3, T4, T5, T6, T7> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            #region Fields

            private readonly T2 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithSecond(T2 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                second(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                return second(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                if (second != null)
                {
                    second(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                if (second != null)
                {
                    return second(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithThird<T, T1, T2, T3, T4, T5, T6, T7> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            #region Fields

            private readonly T3 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithThird(T3 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                third(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                return third(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                if (third != null)
                {
                    third(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                if (third != null)
                {
                    return third(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFourth<T, T1, T2, T3, T4, T5, T6, T7> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            #region Fields

            private readonly T4 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFourth(T4 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                fourth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                return fourth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                if (fourth != null)
                {
                    fourth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                if (fourth != null)
                {
                    return fourth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFifth<T, T1, T2, T3, T4, T5, T6, T7> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            #region Fields

            private readonly T5 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFifth(T5 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                fifth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                return fifth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                if (fifth != null)
                {
                    fifth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                if (fifth != null)
                {
                    return fifth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithSixth<T, T1, T2, T3, T4, T5, T6, T7> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            #region Fields

            private readonly T6 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithSixth(T6 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                sixth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                return sixth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                if (sixth != null)
                {
                    sixth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                if (sixth != null)
                {
                    return sixth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithSeventh<T, T1, T2, T3, T4, T5, T6, T7> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            #region Fields

            private readonly T7 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithSeventh(T7 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                seventh(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                return seventh(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh)
            {
                if (seventh != null)
                {
                    seventh(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh)
            {
                if (seventh != null)
                {
                    return seventh(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFirst<T, T1, T2, T3, T4, T5, T6, T7, T8> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            #region Fields

            private readonly T1 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFirst(T1 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                first(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                return first(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                if (first != null)
                {
                    first(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                if (first != null)
                {
                    return first(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithSecond<T, T1, T2, T3, T4, T5, T6, T7, T8> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            #region Fields

            private readonly T2 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithSecond(T2 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                second(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                return second(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                if (second != null)
                {
                    second(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                if (second != null)
                {
                    return second(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithThird<T, T1, T2, T3, T4, T5, T6, T7, T8> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            #region Fields

            private readonly T3 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithThird(T3 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                third(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                return third(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                if (third != null)
                {
                    third(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                if (third != null)
                {
                    return third(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFourth<T, T1, T2, T3, T4, T5, T6, T7, T8> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            #region Fields

            private readonly T4 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFourth(T4 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                fourth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                return fourth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                if (fourth != null)
                {
                    fourth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                if (fourth != null)
                {
                    return fourth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithFifth<T, T1, T2, T3, T4, T5, T6, T7, T8> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            #region Fields

            private readonly T5 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithFifth(T5 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                fifth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                return fifth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                if (fifth != null)
                {
                    fifth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                if (fifth != null)
                {
                    return fifth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithSixth<T, T1, T2, T3, T4, T5, T6, T7, T8> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            #region Fields

            private readonly T6 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithSixth(T6 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                sixth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                return sixth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                if (sixth != null)
                {
                    sixth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                if (sixth != null)
                {
                    return sixth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithSeventh<T, T1, T2, T3, T4, T5, T6, T7, T8> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            #region Fields

            private readonly T7 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithSeventh(T7 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                seventh(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                return seventh(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                if (seventh != null)
                {
                    seventh(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                if (seventh != null)
                {
                    return seventh(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantWithCommonClassWithEighth<T, T1, T2, T3, T4, T5, T6, T7, T8> : IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
        {
            #region Fields

            private readonly T8 value;

            #endregion

            #region Constructors and Destructors

            internal VariantWithCommonClassWithEighth(T8 value)
            {
                this.value = value;
            }

            #endregion

            #region Explicit Interface Properties

            T IVariantWithCommon<T>.Value
            {
                get
                {
                    return ReferenceEquals(this.value, null) ? default(T) : this.value;
                }
            }

            #endregion

            #region Explicit Interface Methods

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                eighth(this.value);
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                return eighth(this.value);
            }

            void IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome(Action otherwise, Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth)
            {
                if (eighth != null)
                {
                    eighth(this.value);
                }
                else
                {
                    otherwise();
                }
            }

            TResult IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>.MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth)
            {
                if (eighth != null)
                {
                    return eighth(this.value);
                }

                return otherwise();
            }

            #endregion
        }

        private class VariantClassWithFirst<T1, T2> : VariantWithCommonClassWithFirst<object, T1, T2>, IVariant<T1, T2>
        {
            #region Constructors and Destructors

            internal VariantClassWithFirst(T1 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithSecond<T1, T2> : VariantWithCommonClassWithSecond<object, T1, T2>, IVariant<T1, T2>
        {
            #region Constructors and Destructors

            internal VariantClassWithSecond(T2 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFirst<T1, T2, T3> : VariantWithCommonClassWithFirst<object, T1, T2, T3>, IVariant<T1, T2, T3>
        {
            #region Constructors and Destructors

            internal VariantClassWithFirst(T1 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithSecond<T1, T2, T3> : VariantWithCommonClassWithSecond<object, T1, T2, T3>, IVariant<T1, T2, T3>
        {
            #region Constructors and Destructors

            internal VariantClassWithSecond(T2 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithThird<T1, T2, T3> : VariantWithCommonClassWithThird<object, T1, T2, T3>, IVariant<T1, T2, T3>
        {
            #region Constructors and Destructors

            internal VariantClassWithThird(T3 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFirst<T1, T2, T3, T4> : VariantWithCommonClassWithFirst<object, T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>
        {
            #region Constructors and Destructors

            internal VariantClassWithFirst(T1 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithSecond<T1, T2, T3, T4> : VariantWithCommonClassWithSecond<object, T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>
        {
            #region Constructors and Destructors

            internal VariantClassWithSecond(T2 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithThird<T1, T2, T3, T4> : VariantWithCommonClassWithThird<object, T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>
        {
            #region Constructors and Destructors

            internal VariantClassWithThird(T3 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFourth<T1, T2, T3, T4> : VariantWithCommonClassWithFourth<object, T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>
        {
            #region Constructors and Destructors

            internal VariantClassWithFourth(T4 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFirst<T1, T2, T3, T4, T5> : VariantWithCommonClassWithFirst<object, T1, T2, T3, T4, T5>, IVariant<T1, T2, T3, T4, T5>
        {
            #region Constructors and Destructors

            internal VariantClassWithFirst(T1 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithSecond<T1, T2, T3, T4, T5> : VariantWithCommonClassWithSecond<object, T1, T2, T3, T4, T5>, IVariant<T1, T2, T3, T4, T5>
        {
            #region Constructors and Destructors

            internal VariantClassWithSecond(T2 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithThird<T1, T2, T3, T4, T5> : VariantWithCommonClassWithThird<object, T1, T2, T3, T4, T5>, IVariant<T1, T2, T3, T4, T5>
        {
            #region Constructors and Destructors

            internal VariantClassWithThird(T3 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFourth<T1, T2, T3, T4, T5> : VariantWithCommonClassWithFourth<object, T1, T2, T3, T4, T5>, IVariant<T1, T2, T3, T4, T5>
        {
            #region Constructors and Destructors

            internal VariantClassWithFourth(T4 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFifth<T1, T2, T3, T4, T5> : VariantWithCommonClassWithFifth<object, T1, T2, T3, T4, T5>, IVariant<T1, T2, T3, T4, T5>
        {
            #region Constructors and Destructors

            internal VariantClassWithFifth(T5 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFirst<T1, T2, T3, T4, T5, T6> : VariantWithCommonClassWithFirst<object, T1, T2, T3, T4, T5, T6>, IVariant<T1, T2, T3, T4, T5, T6>
        {
            #region Constructors and Destructors

            internal VariantClassWithFirst(T1 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithSecond<T1, T2, T3, T4, T5, T6> : VariantWithCommonClassWithSecond<object, T1, T2, T3, T4, T5, T6>, IVariant<T1, T2, T3, T4, T5, T6>
        {
            #region Constructors and Destructors

            internal VariantClassWithSecond(T2 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithThird<T1, T2, T3, T4, T5, T6> : VariantWithCommonClassWithThird<object, T1, T2, T3, T4, T5, T6>, IVariant<T1, T2, T3, T4, T5, T6>
        {
            #region Constructors and Destructors

            internal VariantClassWithThird(T3 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFourth<T1, T2, T3, T4, T5, T6> : VariantWithCommonClassWithFourth<object, T1, T2, T3, T4, T5, T6>, IVariant<T1, T2, T3, T4, T5, T6>
        {
            #region Constructors and Destructors

            internal VariantClassWithFourth(T4 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFifth<T1, T2, T3, T4, T5, T6> : VariantWithCommonClassWithFifth<object, T1, T2, T3, T4, T5, T6>, IVariant<T1, T2, T3, T4, T5, T6>
        {
            #region Constructors and Destructors

            internal VariantClassWithFifth(T5 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithSixth<T1, T2, T3, T4, T5, T6> : VariantWithCommonClassWithSixth<object, T1, T2, T3, T4, T5, T6>, IVariant<T1, T2, T3, T4, T5, T6>
        {
            #region Constructors and Destructors

            internal VariantClassWithSixth(T6 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFirst<T1, T2, T3, T4, T5, T6, T7> : VariantWithCommonClassWithFirst<object, T1, T2, T3, T4, T5, T6, T7>, IVariant<T1, T2, T3, T4, T5, T6, T7>
        {
            #region Constructors and Destructors

            internal VariantClassWithFirst(T1 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithSecond<T1, T2, T3, T4, T5, T6, T7> : VariantWithCommonClassWithSecond<object, T1, T2, T3, T4, T5, T6, T7>, IVariant<T1, T2, T3, T4, T5, T6, T7>
        {
            #region Constructors and Destructors

            internal VariantClassWithSecond(T2 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithThird<T1, T2, T3, T4, T5, T6, T7> : VariantWithCommonClassWithThird<object, T1, T2, T3, T4, T5, T6, T7>, IVariant<T1, T2, T3, T4, T5, T6, T7>
        {
            #region Constructors and Destructors

            internal VariantClassWithThird(T3 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFourth<T1, T2, T3, T4, T5, T6, T7> : VariantWithCommonClassWithFourth<object, T1, T2, T3, T4, T5, T6, T7>, IVariant<T1, T2, T3, T4, T5, T6, T7>
        {
            #region Constructors and Destructors

            internal VariantClassWithFourth(T4 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFifth<T1, T2, T3, T4, T5, T6, T7> : VariantWithCommonClassWithFifth<object, T1, T2, T3, T4, T5, T6, T7>, IVariant<T1, T2, T3, T4, T5, T6, T7>
        {
            #region Constructors and Destructors

            internal VariantClassWithFifth(T5 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithSixth<T1, T2, T3, T4, T5, T6, T7> : VariantWithCommonClassWithSixth<object, T1, T2, T3, T4, T5, T6, T7>, IVariant<T1, T2, T3, T4, T5, T6, T7>
        {
            #region Constructors and Destructors

            internal VariantClassWithSixth(T6 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithSeventh<T1, T2, T3, T4, T5, T6, T7> : VariantWithCommonClassWithSeventh<object, T1, T2, T3, T4, T5, T6, T7>, IVariant<T1, T2, T3, T4, T5, T6, T7>
        {
            #region Constructors and Destructors

            internal VariantClassWithSeventh(T7 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFirst<T1, T2, T3, T4, T5, T6, T7, T8> : VariantWithCommonClassWithFirst<object, T1, T2, T3, T4, T5, T6, T7, T8>, IVariant<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            #region Constructors and Destructors

            internal VariantClassWithFirst(T1 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithSecond<T1, T2, T3, T4, T5, T6, T7, T8> : VariantWithCommonClassWithSecond<object, T1, T2, T3, T4, T5, T6, T7, T8>, IVariant<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            #region Constructors and Destructors

            internal VariantClassWithSecond(T2 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithThird<T1, T2, T3, T4, T5, T6, T7, T8> : VariantWithCommonClassWithThird<object, T1, T2, T3, T4, T5, T6, T7, T8>, IVariant<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            #region Constructors and Destructors

            internal VariantClassWithThird(T3 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFourth<T1, T2, T3, T4, T5, T6, T7, T8> : VariantWithCommonClassWithFourth<object, T1, T2, T3, T4, T5, T6, T7, T8>, IVariant<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            #region Constructors and Destructors

            internal VariantClassWithFourth(T4 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithFifth<T1, T2, T3, T4, T5, T6, T7, T8> : VariantWithCommonClassWithFifth<object, T1, T2, T3, T4, T5, T6, T7, T8>, IVariant<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            #region Constructors and Destructors

            internal VariantClassWithFifth(T5 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithSixth<T1, T2, T3, T4, T5, T6, T7, T8> : VariantWithCommonClassWithSixth<object, T1, T2, T3, T4, T5, T6, T7, T8>, IVariant<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            #region Constructors and Destructors

            internal VariantClassWithSixth(T6 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithSeventh<T1, T2, T3, T4, T5, T6, T7, T8> : VariantWithCommonClassWithSeventh<object, T1, T2, T3, T4, T5, T6, T7, T8>, IVariant<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            #region Constructors and Destructors

            internal VariantClassWithSeventh(T7 value)
                : base(value)
            {
            }

            #endregion
        }

        private class VariantClassWithEighth<T1, T2, T3, T4, T5, T6, T7, T8> : VariantWithCommonClassWithEighth<object, T1, T2, T3, T4, T5, T6, T7, T8>, IVariant<T1, T2, T3, T4, T5, T6, T7, T8>
        {
            #region Constructors and Destructors

            internal VariantClassWithEighth(T8 value)
                : base(value)
            {
            }

            #endregion
        }
    }
}