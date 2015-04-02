#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VariantCreateNewExtensionMethods.cs" company="MorseCode Software">
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
    using System.Diagnostics.Contracts;

    /// <summary>
    /// Provides extension methods to create a new variant from an existing one with the same types.
    /// </summary>
    public static class VariantCreateNewExtensionMethods
    {
        #region Public Methods and Operators

        /// <summary>
        /// Creates a new variant (or discriminated union) with two possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2> CreateNewFirstWithCommon<T, T1, T2>(this IVariantWithCommon<T, T1, T2> o, T1 value)
            where T1 : T
            where T2 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2>>() != null);

            return Variant.FirstWithCommon<T, T1, T2>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with two possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2> CreateNewSecondWithCommon<T, T1, T2>(this IVariantWithCommon<T, T1, T2> o, T2 value)
            where T1 : T
            where T2 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2>>() != null);

            return Variant.SecondWithCommon<T, T1, T2>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with three possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3> CreateNewFirstWithCommon<T, T1, T2, T3>(this IVariantWithCommon<T, T1, T2, T3> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with three possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3> CreateNewSecondWithCommon<T, T1, T2, T3>(this IVariantWithCommon<T, T1, T2, T3> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with three possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3> CreateNewThirdWithCommon<T, T1, T2, T3>(this IVariantWithCommon<T, T1, T2, T3> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with four possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4> CreateNewFirstWithCommon<T, T1, T2, T3, T4>(this IVariantWithCommon<T, T1, T2, T3, T4> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with four possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4> CreateNewSecondWithCommon<T, T1, T2, T3, T4>(this IVariantWithCommon<T, T1, T2, T3, T4> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with four possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4> CreateNewThirdWithCommon<T, T1, T2, T3, T4>(this IVariantWithCommon<T, T1, T2, T3, T4> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with four possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4> CreateNewFourthWithCommon<T, T1, T2, T3, T4>(this IVariantWithCommon<T, T1, T2, T3, T4> o, T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4>>() != null);

            return Variant.FourthWithCommon<T, T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with five possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5> CreateNewFirstWithCommon<T, T1, T2, T3, T4, T5>(this IVariantWithCommon<T, T1, T2, T3, T4, T5> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with five possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5> CreateNewSecondWithCommon<T, T1, T2, T3, T4, T5>(this IVariantWithCommon<T, T1, T2, T3, T4, T5> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with five possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5> CreateNewThirdWithCommon<T, T1, T2, T3, T4, T5>(this IVariantWithCommon<T, T1, T2, T3, T4, T5> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with five possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5> CreateNewFourthWithCommon<T, T1, T2, T3, T4, T5>(this IVariantWithCommon<T, T1, T2, T3, T4, T5> o, T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5>>() != null);

            return Variant.FourthWithCommon<T, T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with five possible values with a common type
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5> CreateNewFifthWithCommon<T, T1, T2, T3, T4, T5>(this IVariantWithCommon<T, T1, T2, T3, T4, T5> o, T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5>>() != null);

            return Variant.FifthWithCommon<T, T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with six possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> CreateNewFirstWithCommon<T, T1, T2, T3, T4, T5, T6>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with six possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> CreateNewSecondWithCommon<T, T1, T2, T3, T4, T5, T6>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with six possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> CreateNewThirdWithCommon<T, T1, T2, T3, T4, T5, T6>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with six possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> CreateNewFourthWithCommon<T, T1, T2, T3, T4, T5, T6>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> o, T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>>() != null);

            return Variant.FourthWithCommon<T, T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with six possible values with a common type
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> CreateNewFifthWithCommon<T, T1, T2, T3, T4, T5, T6>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> o, T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>>() != null);

            return Variant.FifthWithCommon<T, T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with six possible values with a common type
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> CreateNewSixthWithCommon<T, T1, T2, T3, T4, T5, T6>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6> o, T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6>>() != null);

            return Variant.SixthWithCommon<T, T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> CreateNewFirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> CreateNewSecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> CreateNewThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> CreateNewFourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> o, T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.FourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> CreateNewFifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> o, T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.FifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> CreateNewSixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> o, T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.SixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values with a common type
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> CreateNewSeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7> o, T7 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.SeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> CreateNewFirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> o, T1 value)
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

            return Variant.FirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> CreateNewSecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> o, T2 value)
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

            return Variant.SecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> CreateNewThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> o, T3 value)
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

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> CreateNewFourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> o, T4 value)
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

            return Variant.FourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> CreateNewFifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> o, T5 value)
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

            return Variant.FifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> CreateNewSixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> o, T6 value)
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

            return Variant.SixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> CreateNewSeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> o, T7 value)
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

            return Variant.SeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values with a common type
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> CreateNewEighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8> o, T8 value)
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

            return Variant.EighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewFirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewSecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewFourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.FourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values with a common type
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewFifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.FifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values with a common type
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewSixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.SixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values with a common type
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewSeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T7 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.SeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values with a common type
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewEighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T8 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.EighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values with a common type
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewNinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T9 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.NinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewFirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewSecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewFourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.FourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values with a common type
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewFifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.FifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values with a common type
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewSixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.SixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values with a common type
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewSeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T7 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.SeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values with a common type
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewEighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T8 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.EighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values with a common type
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewNinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T9 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.NinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values with a common type
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewTenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T10 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.TenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewFirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewSecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewFourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.FourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values with a common type
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewFifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.FifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values with a common type
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewSixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.SixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values with a common type
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewSeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T7 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.SeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values with a common type
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewEighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T8 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.EighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values with a common type
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewNinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T9 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.NinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values with a common type
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewTenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T10 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.TenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values with a common type
        /// holding a value of the eleventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewEleventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T11 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.EleventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewFirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewSecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewFourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.FourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values with a common type
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewFifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.FifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values with a common type
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewSixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.SixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values with a common type
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewSeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T7 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.SeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values with a common type
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewEighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T8 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.EighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values with a common type
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewNinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T9 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.NinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values with a common type
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewTenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T10 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.TenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values with a common type
        /// holding a value of the eleventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewEleventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T11 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.EleventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values with a common type
        /// holding a value of the twelfth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewTwelfthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T12 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.TwelfthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewFirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewSecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewFourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.FourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewFifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.FifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewSixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.SixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewSeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T7 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.SeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewEighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T8 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.EighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewNinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T9 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.NinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewTenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T10 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.TenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the eleventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewEleventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T11 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.EleventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the twelfth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewTwelfthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T12 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.TwelfthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values with a common type
        /// holding a value of the thirteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the thirteenth possible variant value (of type <typeparamref name="T13"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewThirteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T13 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.ThirteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewFirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewSecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewFourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.FourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewFifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.FifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewSixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.SixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewSeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T7 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.SeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewEighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T8 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.EighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewNinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T9 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.NinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewTenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T10 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.TenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the eleventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewEleventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T11 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.EleventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the twelfth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewTwelfthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T12 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.TwelfthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the thirteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the thirteenth possible variant value (of type <typeparamref name="T13"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewThirteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T13 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.ThirteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values with a common type
        /// holding a value of the fourteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the fourteenth possible variant value (of type <typeparamref name="T14"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewFourteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T14 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.FourteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewFirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewSecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewFourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.FourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewFifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.FifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewSixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.SixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewSeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T7 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.SeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewEighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T8 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.EighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewNinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T9 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.NinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewTenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T10 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.TenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the eleventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewEleventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T11 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.EleventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the twelfth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewTwelfthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T12 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.TwelfthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the thirteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the thirteenth possible variant value (of type <typeparamref name="T13"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewThirteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T13 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.ThirteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the fourteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the fourteenth possible variant value (of type <typeparamref name="T14"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewFourteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T14 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.FourteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values with a common type
        /// holding a value of the fifteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the fifteenth possible variant value (of type <typeparamref name="T15"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewFifteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T15 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.FifteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewFirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T1 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.FirstWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewSecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T2 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.SecondWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T3 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.ThirdWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewFourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T4 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.FourthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewFifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T5 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.FifthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewSixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T6 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.SixthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewSeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T7 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.SeventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewEighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T8 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.EighthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewNinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T9 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.NinthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewTenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T10 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.TenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the eleventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewEleventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T11 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.EleventhWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the twelfth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewTwelfthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T12 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.TwelfthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the thirteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the thirteenth possible variant value (of type <typeparamref name="T13"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewThirteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T13 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.ThirteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the fourteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the fourteenth possible variant value (of type <typeparamref name="T14"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewFourteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T14 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.FourteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the fifteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the fifteenth possible variant value (of type <typeparamref name="T15"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewFifteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T15 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.FifteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values with a common type
        /// holding a value of the sixteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the sixteenth possible variant value (of type <typeparamref name="T16"/>).
        /// </returns>
        public static IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewSixteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T16 value)
            where T1 : T
            where T2 : T
            where T3 : T
            where T4 : T
            where T5 : T
            where T6 : T
            where T7 : T
            where T8 : T
            where T9 : T
            where T10 : T
            where T11 : T
            where T12 : T
            where T13 : T
            where T14 : T
            where T15 : T
            where T16 : T
        {
            Contract.Ensures(Contract.Result<IVariantWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.SixteenthWithCommon<T, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with two possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2> CreateNewFirst<T1, T2>(this IVariant<T1, T2> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2>>() != null);

            return Variant.First<T1, T2>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with two possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2> CreateNewSecond<T1, T2>(this IVariant<T1, T2> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2>>() != null);

            return Variant.Second<T1, T2>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with three possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3> CreateNewFirst<T1, T2, T3>(this IVariant<T1, T2, T3> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            return Variant.First<T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with three possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3> CreateNewSecond<T1, T2, T3>(this IVariant<T1, T2, T3> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            return Variant.Second<T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with three possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3> CreateNewThird<T1, T2, T3>(this IVariant<T1, T2, T3> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            return Variant.Third<T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with four possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4> CreateNewFirst<T1, T2, T3, T4>(this IVariant<T1, T2, T3, T4> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            return Variant.First<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with four possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4> CreateNewSecond<T1, T2, T3, T4>(this IVariant<T1, T2, T3, T4> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            return Variant.Second<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with four possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4> CreateNewThird<T1, T2, T3, T4>(this IVariant<T1, T2, T3, T4> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            return Variant.Third<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with four possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4> CreateNewFourth<T1, T2, T3, T4>(this IVariant<T1, T2, T3, T4> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            return Variant.Fourth<T1, T2, T3, T4>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with five possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5> CreateNewFirst<T1, T2, T3, T4, T5>(this IVariant<T1, T2, T3, T4, T5> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5>>() != null);

            return Variant.First<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with five possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5> CreateNewSecond<T1, T2, T3, T4, T5>(this IVariant<T1, T2, T3, T4, T5> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5>>() != null);

            return Variant.Second<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with five possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5> CreateNewThird<T1, T2, T3, T4, T5>(this IVariant<T1, T2, T3, T4, T5> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5>>() != null);

            return Variant.Third<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with five possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5> CreateNewFourth<T1, T2, T3, T4, T5>(this IVariant<T1, T2, T3, T4, T5> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5>>() != null);

            return Variant.Fourth<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with five possible values
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5> CreateNewFifth<T1, T2, T3, T4, T5>(this IVariant<T1, T2, T3, T4, T5> o, T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5>>() != null);

            return Variant.Fifth<T1, T2, T3, T4, T5>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with six possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6> CreateNewFirst<T1, T2, T3, T4, T5, T6>(this IVariant<T1, T2, T3, T4, T5, T6> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6>>() != null);

            return Variant.First<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with six possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6> CreateNewSecond<T1, T2, T3, T4, T5, T6>(this IVariant<T1, T2, T3, T4, T5, T6> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6>>() != null);

            return Variant.Second<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with six possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6> CreateNewThird<T1, T2, T3, T4, T5, T6>(this IVariant<T1, T2, T3, T4, T5, T6> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6>>() != null);

            return Variant.Third<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with six possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6> CreateNewFourth<T1, T2, T3, T4, T5, T6>(this IVariant<T1, T2, T3, T4, T5, T6> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6>>() != null);

            return Variant.Fourth<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with six possible values
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6> CreateNewFifth<T1, T2, T3, T4, T5, T6>(this IVariant<T1, T2, T3, T4, T5, T6> o, T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6>>() != null);

            return Variant.Fifth<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with six possible values
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6> CreateNewSixth<T1, T2, T3, T4, T5, T6>(this IVariant<T1, T2, T3, T4, T5, T6> o, T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6>>() != null);

            return Variant.Sixth<T1, T2, T3, T4, T5, T6>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> CreateNewFirst<T1, T2, T3, T4, T5, T6, T7>(this IVariant<T1, T2, T3, T4, T5, T6, T7> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.First<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> CreateNewSecond<T1, T2, T3, T4, T5, T6, T7>(this IVariant<T1, T2, T3, T4, T5, T6, T7> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.Second<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> CreateNewThird<T1, T2, T3, T4, T5, T6, T7>(this IVariant<T1, T2, T3, T4, T5, T6, T7> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.Third<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> CreateNewFourth<T1, T2, T3, T4, T5, T6, T7>(this IVariant<T1, T2, T3, T4, T5, T6, T7> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.Fourth<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> CreateNewFifth<T1, T2, T3, T4, T5, T6, T7>(this IVariant<T1, T2, T3, T4, T5, T6, T7> o, T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.Fifth<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> CreateNewSixth<T1, T2, T3, T4, T5, T6, T7>(this IVariant<T1, T2, T3, T4, T5, T6, T7> o, T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.Sixth<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with seven possible values
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7> CreateNewSeventh<T1, T2, T3, T4, T5, T6, T7>(this IVariant<T1, T2, T3, T4, T5, T6, T7> o, T7 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7>>() != null);

            return Variant.Seventh<T1, T2, T3, T4, T5, T6, T7>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> CreateNewFirst<T1, T2, T3, T4, T5, T6, T7, T8>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return Variant.First<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> CreateNewSecond<T1, T2, T3, T4, T5, T6, T7, T8>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return Variant.Second<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> CreateNewThird<T1, T2, T3, T4, T5, T6, T7, T8>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return Variant.Third<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> CreateNewFourth<T1, T2, T3, T4, T5, T6, T7, T8>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return Variant.Fourth<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> CreateNewFifth<T1, T2, T3, T4, T5, T6, T7, T8>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8> o, T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return Variant.Fifth<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> CreateNewSixth<T1, T2, T3, T4, T5, T6, T7, T8>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8> o, T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return Variant.Sixth<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> CreateNewSeventh<T1, T2, T3, T4, T5, T6, T7, T8>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8> o, T7 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return Variant.Seventh<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eight possible values
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8> CreateNewEighth<T1, T2, T3, T4, T5, T6, T7, T8>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8> o, T8 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8>>() != null);

            return Variant.Eighth<T1, T2, T3, T4, T5, T6, T7, T8>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.First<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewSecond<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.Second<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewThird<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.Third<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewFourth<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.Fourth<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewFifth<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.Fifth<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewSixth<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.Sixth<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewSeventh<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T7 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.Seventh<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewEighth<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T8 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.Eighth<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with nine possible values
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> CreateNewNinth<T1, T2, T3, T4, T5, T6, T7, T8, T9>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9> o, T9 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9>>() != null);

            return Variant.Ninth<T1, T2, T3, T4, T5, T6, T7, T8, T9>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.First<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewSecond<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.Second<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewThird<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.Third<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewFourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.Fourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewFifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.Fifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewSixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.Sixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewSeventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T7 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.Seventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewEighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T8 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.Eighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewNinth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T9 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.Ninth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with ten possible values
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> CreateNewTenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> o, T10 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>() != null);

            return Variant.Tenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.First<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewSecond<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.Second<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewThird<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.Third<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewFourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.Fourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewFifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.Fifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewSixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.Sixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewSeventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T7 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.Seventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewEighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T8 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.Eighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewNinth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T9 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.Ninth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewTenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T10 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.Tenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with eleven possible values
        /// holding a value of the eleventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11}"/> holding a value of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> CreateNewEleventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> o, T11 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>() != null);

            return Variant.Eleventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.First<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewSecond<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.Second<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewThird<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.Third<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewFourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.Fourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewFifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.Fifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewSixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.Sixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewSeventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T7 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.Seventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewEighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T8 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.Eighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewNinth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T9 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.Ninth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewTenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T10 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.Tenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values
        /// holding a value of the eleventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewEleventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T11 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.Eleventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with twelve possible values
        /// holding a value of the twelfth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12}"/> holding a value of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> CreateNewTwelfth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> o, T12 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>() != null);

            return Variant.Twelfth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.First<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewSecond<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.Second<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewThird<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.Third<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewFourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.Fourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewFifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.Fifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewSixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.Sixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewSeventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T7 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.Seventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewEighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T8 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.Eighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewNinth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T9 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.Ninth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewTenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T10 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.Tenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the eleventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewEleventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T11 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.Eleventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the twelfth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewTwelfth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T12 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.Twelfth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with thirteen possible values
        /// holding a value of the thirteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13}"/> holding a value of the thirteenth possible variant value (of type <typeparamref name="T13"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> CreateNewThirteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> o, T13 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>() != null);

            return Variant.Thirteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.First<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewSecond<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Second<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewThird<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Third<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewFourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Fourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewFifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Fifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewSixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Sixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewSeventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T7 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Seventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewEighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T8 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Eighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewNinth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T9 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Ninth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewTenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T10 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Tenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the eleventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewEleventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T11 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Eleventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the twelfth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewTwelfth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T12 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Twelfth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the thirteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the thirteenth possible variant value (of type <typeparamref name="T13"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewThirteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T13 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Thirteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fourteen possible values
        /// holding a value of the fourteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14}"/> holding a value of the fourteenth possible variant value (of type <typeparamref name="T14"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> CreateNewFourteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> o, T14 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>() != null);

            return Variant.Fourteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.First<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewSecond<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Second<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewThird<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Third<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewFourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Fourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewFifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Fifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewSixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Sixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewSeventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T7 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Seventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewEighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T8 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Eighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewNinth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T9 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Ninth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewTenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T10 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Tenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the eleventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewEleventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T11 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Eleventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the twelfth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewTwelfth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T12 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Twelfth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the thirteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the thirteenth possible variant value (of type <typeparamref name="T13"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewThirteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T13 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Thirteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the fourteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the fourteenth possible variant value (of type <typeparamref name="T14"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewFourteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T14 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Fourteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with fifteen possible values
        /// holding a value of the fifteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15}"/> holding a value of the fifteenth possible variant value (of type <typeparamref name="T15"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> CreateNewFifteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> o, T15 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>() != null);

            return Variant.Fifteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the first possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewFirst<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T1 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.First<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the second possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewSecond<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T2 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Second<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the third possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewThird<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T3 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Third<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the fourth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewFourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T4 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Fourth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the fifth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewFifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T5 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Fifth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the sixth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewSixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T6 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Sixth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the seventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewSeventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T7 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Seventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the eighth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewEighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T8 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Eighth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the ninth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewNinth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T9 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Ninth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the tenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewTenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T10 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Tenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the eleventh possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewEleventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T11 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Eleventh<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the twelfth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewTwelfth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T12 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Twelfth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the thirteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the thirteenth possible variant value (of type <typeparamref name="T13"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewThirteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T13 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Thirteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the fourteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the fourteenth possible variant value (of type <typeparamref name="T14"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewFourteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T14 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Fourteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the fifteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the fifteenth possible variant value (of type <typeparamref name="T15"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewFifteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T15 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Fifteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        /// <summary>
        /// Creates a new variant (or discriminated union) with sixteen possible values
        /// holding a value of the sixteenth possible variant value from an existing variant value of the same types (which may be <c>null</c>).
        /// </summary>
        /// <param name="o">
        /// The existing variant value of the same types (which may be <c>null</c>) to infer types from.
        /// </param>
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
        /// <typeparam name="T9">
        /// The type of the ninth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T10">
        /// The type of the tenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T11">
        /// The type of the eleventh possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T12">
        /// The type of the twelfth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T13">
        /// The type of the thirteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T14">
        /// The type of the fourteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T15">
        /// The type of the fifteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T16">
        /// The type of the sixteenth possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The <see cref="IVariant{T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}"/> holding a value of the sixteenth possible variant value (of type <typeparamref name="T16"/>).
        /// </returns>
        public static IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> CreateNewSixteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(this IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> o, T16 value)
        {
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>() != null);

            return Variant.Sixteenth<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(value);
        }

        #endregion
    }
}