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

        #endregion
    }
}