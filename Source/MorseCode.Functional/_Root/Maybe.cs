#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Maybe.cs" company="MorseCode Software">
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

    using MorseCode.FrameworkExtensions;

    /// <summary>
    /// A factory class for creating <see cref="IMaybe{T}"/> instances.
    /// </summary>
    public static class Maybe
    {
        #region Public Methods and Operators

        /// <summary>
        /// Creates an <see cref="IMaybe{T}"/> with a value of type <typeparamref name="T"/>.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <typeparam name="T">
        /// The type of the value held by this <see cref="IMaybe{T}"/>.
        /// </typeparam>
        /// <returns>
        /// The <see cref="IMaybe{T}"/> with the value <paramref name="value"/>.
        /// </returns>
        public static IMaybe<T> Just<T>(T value)
        {
            return new JustClass<T>(value);
        }

        /// <summary>
        /// Creates an <see cref="IMaybe{T}"/> with no value.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the value held by this <see cref="IMaybe{T}"/>.
        /// </typeparam>
        /// <returns>
        /// The <see cref="IMaybe{T}"/> with no value.
        /// </returns>
        public static IMaybe<T> Nothing<T>()
        {
            return NothingClass<T>.Value;
        }

        #endregion

        private class JustClass<T> : IMaybe<T>
        {
            #region Fields

            private readonly T value;

            #endregion

            #region Constructors and Destructors

            internal JustClass(T value)
            {
                this.value = value;
            }

            #endregion

            #region Public Methods and Operators

            public override string ToString()
            {
                return "Just: " + this.value.SafeToString();
            }

            #endregion

            #region Explicit Interface Methods

            void IMaybe<T>.Match(Action<T> hasValueAction, Action nothingAction)
            {
                hasValueAction(this.value);
            }

            TResult IMaybe<T>.Match<TResult>(Func<T, TResult> hasValueFunc, Func<TResult> nothingFunc)
            {
                return hasValueFunc(this.value);
            }

            #endregion
        }

        private class NothingClass<T> : IMaybe<T>
        {
            #region Static Fields

            public static readonly NothingClass<T> Value = new NothingClass<T>();

            #endregion

            #region Constructors and Destructors

            private NothingClass()
            {
            }

            #endregion

            #region Public Methods and Operators

            public override string ToString()
            {
                return "Nothing";
            }

            #endregion

            #region Explicit Interface Methods

            void IMaybe<T>.Match(Action<T> hasValueAction, Action nothingAction)
            {
                nothingAction();
            }

            TResult IMaybe<T>.Match<TResult>(Func<T, TResult> hasValueFunc, Func<TResult> nothingFunc)
            {
                return nothingFunc();
            }

            #endregion
        }
    }
}