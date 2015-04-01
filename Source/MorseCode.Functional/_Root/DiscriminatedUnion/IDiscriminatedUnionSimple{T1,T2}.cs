#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDiscriminatedUnionSimple{T1,T2}.cs" company="MorseCode Software">
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

    /// <summary>
    /// Interface representing the F# discriminated union with two possible types.  A value may only be specified for one of the types at a time.
    /// </summary>
    /// <typeparam name="T1">
    /// The first type of the discriminated union.
    /// </typeparam>
    /// <typeparam name="T2">
    /// The second type of the discriminated union.
    /// </typeparam>
    [ContractClass(typeof(DiscriminatedUnionSimpleInterfaceContract<,>))]
    public interface IDiscriminatedUnionSimple<out T1, out T2>
    {
        #region Public Properties

        /// <summary>
        /// Gets the value of type <typeparamref name="T1" /> if <see cref="IsFirst"/> is <c>true</c>, otherwise returns the default value for type <typeparamref name="T1" />.
        /// </summary>
        T1 First { get; }

        /// <summary>
        /// Gets a value indicating whether the discriminated union is holding a value of the type <typeparamref name="T1" />.
        /// </summary>
        bool IsFirst { get; }

        /// <summary>
        /// Gets a value indicating whether the discriminated union is holding a value of the type <typeparamref name="T2" />.
        /// </summary>
        bool IsSecond { get; }

        /// <summary>
        /// Gets the value of type <typeparamref name="T2" /> if <see cref="IsSecond"/> is <c>true</c>, otherwise returns the default value for type <typeparamref name="T2" />.
        /// </summary>
        T2 Second { get; }

        #endregion

        #region Public Methods and Operators

        /// <summary>
        /// Executes an action based on which value is contained in the discriminated union.
        /// </summary>
        /// <param name="first">
        /// The action to run if <see cref="IsFirst"/> is <c>true</c>.
        /// </param>
        /// <param name="second">
        /// The action to run if <see cref="IsSecond"/> is <c>true</c>.
        /// </param>
        void Switch(Action<T1> first, Action<T2> second);

        /// <summary>
        /// Executes a function based on which value is contained in the discriminated union.
        /// </summary>
        /// <param name="first">
        /// The function to run if <see cref="IsFirst"/> is <c>true</c>.
        /// </param>
        /// <param name="second">
        /// The function to run if <see cref="IsSecond"/> is <c>true</c>.
        /// </param>
        /// <typeparam name="TResult">
        /// The type of the result.
        /// </typeparam>
        /// <returns>
        /// The result of type <typeparamref name="TResult"/> of the function executed.
        /// </returns>
        TResult Switch<TResult>(Func<T1, TResult> first, Func<T2, TResult> second);

        #endregion
    }
}