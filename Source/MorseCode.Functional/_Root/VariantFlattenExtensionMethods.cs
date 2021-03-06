﻿#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VariantFlattenExtensionMethods.cs" company="MorseCode Software">
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
    /// Provides extension methods to create a new variant from an existing one with the same types.
    /// </summary>
    public static class VariantFlattenExtensionMethods
    {
        #region Public Methods and Operators

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2> Flatten<T1, T2>(this IVariant<IVariant<T1, T2>, IVariant<T1, T2>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2>>() != null);

            IVariant<T1, T2> variant = o.Match(u => u.Match(v => Variant.First<T1, T2>(v), Variant.Second<T1, T2>), u => u.Match(v => Variant.First<T1, T2>(v), Variant.Second<T1, T2>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2> Flatten<T1, T2>(this IVariant<T1, IVariant<T1, T2>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2>>() != null);

            IVariant<T1, T2> variant = o.Match(Variant.First<T1, T2>, u => u.Match(v => Variant.First<T1, T2>(v), Variant.Second<T1, T2>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
        /// </param>
        /// <typeparam name="T1">
        /// The type of the first possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the second possible value of the variant (or discriminated union).
        /// </typeparam>
        /// <returns>
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2> Flatten<T1, T2>(this IVariant<IVariant<T1, T2>, T2> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2>>() != null);

            IVariant<T1, T2> variant = o.Match(u => u.Match(v => Variant.First<T1, T2>(v), Variant.Second<T1, T2>), Variant.Second<T1, T2>);
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3> Flatten<T1, T2, T3>(this IVariant<IVariant<T1, T2, T3>, IVariant<T1, T2, T3>, IVariant<T1, T2, T3>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            IVariant<T1, T2, T3> variant = o.Match(u => u.Match(v => Variant.First<T1, T2, T3>(v), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>), u => u.Match(v => Variant.First<T1, T2, T3>(v), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>), u => u.Match(v => Variant.First<T1, T2, T3>(v), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3> Flatten<T1, T2, T3>(this IVariant<T1, IVariant<T1, T2, T3>, IVariant<T1, T2, T3>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            IVariant<T1, T2, T3> variant = o.Match(Variant.First<T1, T2, T3>, u => u.Match(v => Variant.First<T1, T2, T3>(v), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>), u => u.Match(v => Variant.First<T1, T2, T3>(v), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3> Flatten<T1, T2, T3>(this IVariant<IVariant<T1, T2, T3>, T2, IVariant<T1, T2, T3>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            IVariant<T1, T2, T3> variant = o.Match(u => u.Match(v => Variant.First<T1, T2, T3>(v), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>), Variant.Second<T1, T2, T3>, u => u.Match(v => Variant.First<T1, T2, T3>(v), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3> Flatten<T1, T2, T3>(this IVariant<T1, T2, IVariant<T1, T2, T3>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            IVariant<T1, T2, T3> variant = o.Match(Variant.First<T1, T2, T3>, Variant.Second<T1, T2, T3>, u => u.Match(v => Variant.First<T1, T2, T3>(v), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3> Flatten<T1, T2, T3>(this IVariant<IVariant<T1, T2, T3>, IVariant<T1, T2, T3>, T3> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            IVariant<T1, T2, T3> variant = o.Match(u => u.Match(v => Variant.First<T1, T2, T3>(v), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>), u => u.Match(v => Variant.First<T1, T2, T3>(v), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>), Variant.Third<T1, T2, T3>);
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3> Flatten<T1, T2, T3>(this IVariant<T1, IVariant<T1, T2, T3>, T3> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            IVariant<T1, T2, T3> variant = o.Match(Variant.First<T1, T2, T3>, u => u.Match(v => Variant.First<T1, T2, T3>(v), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>), Variant.Third<T1, T2, T3>);
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3> Flatten<T1, T2, T3>(this IVariant<IVariant<T1, T2, T3>, T2, T3> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3>>() != null);

            IVariant<T1, T2, T3> variant = o.Match(u => u.Match(v => Variant.First<T1, T2, T3>(v), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>), Variant.Second<T1, T2, T3>, Variant.Third<T1, T2, T3>);
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<IVariant<T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<T1, IVariant<T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(Variant.First<T1, T2, T3, T4>, u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<IVariant<T1, T2, T3, T4>, T2, IVariant<T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), Variant.Second<T1, T2, T3, T4>, u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<T1, T2, IVariant<T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(Variant.First<T1, T2, T3, T4>, Variant.Second<T1, T2, T3, T4>, u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<IVariant<T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>, T3, IVariant<T1, T2, T3, T4>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), Variant.Third<T1, T2, T3, T4>, u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<T1, IVariant<T1, T2, T3, T4>, T3, IVariant<T1, T2, T3, T4>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(Variant.First<T1, T2, T3, T4>, u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), Variant.Third<T1, T2, T3, T4>, u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<IVariant<T1, T2, T3, T4>, T2, T3, IVariant<T1, T2, T3, T4>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<T1, T2, T3, IVariant<T1, T2, T3, T4>> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(Variant.First<T1, T2, T3, T4>, Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>));
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<IVariant<T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>, T4> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), Variant.Fourth<T1, T2, T3, T4>);
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<T1, IVariant<T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>, T4> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(Variant.First<T1, T2, T3, T4>, u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), Variant.Fourth<T1, T2, T3, T4>);
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<IVariant<T1, T2, T3, T4>, T2, IVariant<T1, T2, T3, T4>, T4> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), Variant.Second<T1, T2, T3, T4>, u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), Variant.Fourth<T1, T2, T3, T4>);
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<T1, T2, IVariant<T1, T2, T3, T4>, T4> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(Variant.First<T1, T2, T3, T4>, Variant.Second<T1, T2, T3, T4>, u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), Variant.Fourth<T1, T2, T3, T4>);
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<IVariant<T1, T2, T3, T4>, IVariant<T1, T2, T3, T4>, T3, T4> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>);
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<T1, IVariant<T1, T2, T3, T4>, T3, T4> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(Variant.First<T1, T2, T3, T4>, u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>);
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        /// <summary>
        /// Flattens a nested variant (or discriminated union) to produce a single variant (or discriminated union).
        /// </summary>
        /// <param name="o">
        /// The variant (or discriminated union) instance to flatten.
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
        /// The flattened variant (or discriminated union).
        /// </returns>
        public static IVariant<T1, T2, T3, T4> Flatten<T1, T2, T3, T4>(this IVariant<IVariant<T1, T2, T3, T4>, T2, T3, T4> o)
        {
            Contract.Requires<ArgumentNullException>(o != null, "o");
            Contract.Ensures(Contract.Result<IVariant<T1, T2, T3, T4>>() != null);

            IVariant<T1, T2, T3, T4> variant = o.Match(u => u.Match(v => Variant.First<T1, T2, T3, T4>(v), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>), Variant.Second<T1, T2, T3, T4>, Variant.Third<T1, T2, T3, T4>, Variant.Fourth<T1, T2, T3, T4>);
            if (variant == null)
            {
                throw new InvalidOperationException("Result may not be null.");
            }

            return variant;
        }

        #endregion
    }
}
