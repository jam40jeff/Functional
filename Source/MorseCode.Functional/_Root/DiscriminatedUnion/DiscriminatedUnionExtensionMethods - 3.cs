#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DiscriminatedUnionExtensionMethods - 3.cs" company="MorseCode Software">
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

namespace MorseCode.Functional.DiscriminatedUnion
{
    using System;
    using System.Diagnostics.Contracts;

    using MorseCode.BetterReflection;

    /// <summary>
    /// Discriminated union extension methods.
    /// </summary>
    public static partial class DiscriminatedUnionExtensionMethods
    {
        #region Public Methods and Operators

        /// <summary>
        /// Creates a new instance of a discriminated union with a value of type <typeparamref name="T1"/>.
        /// </summary>
        /// <param name="o">
        /// The discriminated union instance from which to infer the generic type parameters.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="TCommon">
        /// The common type of all types allowed in the discriminated union.
        /// </typeparam>
        /// <typeparam name="T1">
        /// The first type of the discriminated union.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The second type of the discriminated union.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The third type of the discriminated union.
        /// </typeparam>
        /// <returns>
        /// The new instance of a discriminated union.
        /// </returns>
        public static IDiscriminatedUnion<TCommon, T1, T2, T3> CreateFirst<TCommon, T1, T2, T3>(
            this IDiscriminatedUnion<TCommon, T1, T2, T3> o, T1 value)
            where T1 : TCommon
            where T2 : TCommon
            where T3 : TCommon
            where TCommon : class
        {
            Contract.Ensures(Contract.Result<IDiscriminatedUnion<TCommon, T1, T2, T3>>() != null);

            return DiscriminatedUnion.First<TCommon, T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a new instance of a discriminated union with a value of type <typeparamref name="T2"/>.
        /// </summary>
        /// <param name="o">
        /// The discriminated union instance from which to infer the generic type parameters.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="TCommon">
        /// The common type of all types allowed in the discriminated union.
        /// </typeparam>
        /// <typeparam name="T1">
        /// The first type of the discriminated union.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The second type of the discriminated union.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The third type of the discriminated union.
        /// </typeparam>
        /// <returns>
        /// The new instance of a discriminated union.
        /// </returns>
        public static IDiscriminatedUnion<TCommon, T1, T2, T3> CreateSecond<TCommon, T1, T2, T3>(
            this IDiscriminatedUnion<TCommon, T1, T2, T3> o, T2 value)
            where T1 : TCommon
            where T2 : TCommon
            where T3 : TCommon
            where TCommon : class
        {
            Contract.Ensures(Contract.Result<IDiscriminatedUnion<TCommon, T1, T2, T3>>() != null);

            return DiscriminatedUnion.Second<TCommon, T1, T2, T3>(value);
        }

        /// <summary>
        /// Creates a new instance of a discriminated union with a value of type <typeparamref name="T3"/>.
        /// </summary>
        /// <param name="o">
        /// The discriminated union instance from which to infer the generic type parameters.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="TCommon">
        /// The common type of all types allowed in the discriminated union.
        /// </typeparam>
        /// <typeparam name="T1">
        /// The first type of the discriminated union.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The second type of the discriminated union.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The third type of the discriminated union.
        /// </typeparam>
        /// <returns>
        /// The new instance of a discriminated union.
        /// </returns>
        public static IDiscriminatedUnion<TCommon, T1, T2, T3> CreateThird<TCommon, T1, T2, T3>(
            this IDiscriminatedUnion<TCommon, T1, T2, T3> o, T3 value)
            where T1 : TCommon
            where T2 : TCommon
            where T3 : TCommon
            where TCommon : class
        {
            Contract.Ensures(Contract.Result<IDiscriminatedUnion<TCommon, T1, T2, T3>>() != null);

            return DiscriminatedUnion.Third<TCommon, T1, T2, T3>(value);
        }

        /// <summary>
        /// Flattens a nested discriminated union to produce a single discriminated union.
        /// </summary>
        /// <param name="o">
        /// The discriminated union instance to flatten.
        /// </param>
        /// <typeparam name="T1">
        /// The first type of the discriminated union.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The second type of the discriminated union.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The third type of the discriminated union.
        /// </typeparam>
        /// <returns>
        /// The flattened discriminated union.
        /// </returns>
        public static IDiscriminatedUnion<object, T1, T2, T3> Flatten<T1, T2, T3>(
            this IDiscriminatedUnion<object, IDiscriminatedUnion<object, T1, T2, T3>, T2, T3> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IDiscriminatedUnion<object, T1, T2, T3>>() != null);

            IDiscriminatedUnion<object, T1, T2, T3> discriminatedUnion = o.Switch(u => u.Switch(v => DiscriminatedUnion.First<object, T1, T2, T3>(v), DiscriminatedUnion.Second<object, T1, T2, T3>, DiscriminatedUnion.Third<object, T1, T2, T3>), DiscriminatedUnion.Second<object, T1, T2, T3>, DiscriminatedUnion.Third<object, T1, T2, T3>);
            if (discriminatedUnion == null)
            {
                throw new InvalidOperationException(
                    "Result of "
                    + StaticReflection<IDiscriminatedUnion<object, IDiscriminatedUnion<object, T1, T2, T3>, T2, T3>>
                          .GetMethodName(o2 => o2.Switch(null, null, null)) + " cannot be null.");
            }

            return discriminatedUnion;
        }

        /// <summary>
        /// Flattens a nested discriminated union to produce a single discriminated union.
        /// </summary>
        /// <param name="o">
        /// The discriminated union instance to flatten.
        /// </param>
        /// <typeparam name="T1">
        /// The first type of the discriminated union.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The second type of the discriminated union.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The third type of the discriminated union.
        /// </typeparam>
        /// <returns>
        /// The flattened discriminated union.
        /// </returns>
        public static IDiscriminatedUnion<object, T1, T2, T3> Flatten<T1, T2, T3>(
            this IDiscriminatedUnion<object, T1, IDiscriminatedUnion<object, T1, T2, T3>, T3> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IDiscriminatedUnion<object, T1, T2, T3>>() != null);

            IDiscriminatedUnion<object, T1, T2, T3> discriminatedUnion = o.Switch(DiscriminatedUnion.First<object, T1, T2, T3>, u => u.Switch(v => DiscriminatedUnion.First<object, T1, T2, T3>(v), DiscriminatedUnion.Second<object, T1, T2, T3>, DiscriminatedUnion.Third<object, T1, T2, T3>), DiscriminatedUnion.Third<object, T1, T2, T3>);
            if (discriminatedUnion == null)
            {
                throw new InvalidOperationException(
                    "Result of "
                    + StaticReflection<IDiscriminatedUnion<object, T1, IDiscriminatedUnion<object, T1, T2, T3>, T3>>
                          .GetMethodName(o2 => o2.Switch(null, null, null)) + " cannot be null.");
            }

            return discriminatedUnion;
        }

        /// <summary>
        /// Flattens a nested discriminated union to produce a single discriminated union.
        /// </summary>
        /// <param name="o">
        /// The discriminated union instance to flatten.
        /// </param>
        /// <typeparam name="T1">
        /// The first type of the discriminated union.
        /// </typeparam>
        /// <typeparam name="T2">
        /// The second type of the discriminated union.
        /// </typeparam>
        /// <typeparam name="T3">
        /// The third type of the discriminated union.
        /// </typeparam>
        /// <returns>
        /// The flattened discriminated union.
        /// </returns>
        public static IDiscriminatedUnion<object, T1, T2, T3> Flatten<T1, T2, T3>(
            this IDiscriminatedUnion<object, T1, T2, IDiscriminatedUnion<object, T1, T2, T3>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IDiscriminatedUnion<object, T1, T2, T3>>() != null);

            IDiscriminatedUnion<object, T1, T2, T3> discriminatedUnion = o.Switch(DiscriminatedUnion.First<object, T1, T2, T3>, DiscriminatedUnion.Second<object, T1, T2, T3>, u => u.Switch(v => DiscriminatedUnion.First<object, T1, T2, T3>(v), DiscriminatedUnion.Second<object, T1, T2, T3>, DiscriminatedUnion.Third<object, T1, T2, T3>));
            if (discriminatedUnion == null)
            {
                throw new InvalidOperationException(
                    "Result of "
                    + StaticReflection<IDiscriminatedUnion<object, T1, T2, IDiscriminatedUnion<object, T1, T2, T3>>>
                          .GetMethodName(o2 => o2.Switch(null, null, null)) + " cannot be null.");
            }

            return discriminatedUnion;
        }

        #endregion
    }
}