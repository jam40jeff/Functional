#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MaybeMonad.cs" company="MorseCode Software">
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

    public static class MaybeMonad
    {
        #region Public Methods and Operators

        public static IMaybe<TResult> Bind<T, TResult>(this IMaybe<T> value, Func<T, IMaybe<TResult>> transformation)
        {
            return value.Switch(transformation, Maybe.Nothing<TResult>);
        }

        public static IMaybe<T> Return<T>(T value)
        {
            return Maybe.Just(value);
        }

        public static IMaybe<TResult> SelectMany<T1, T2, TResult>(this IMaybe<T1> value, Func<T1, IMaybe<T2>> transformation, Func<T1, T2, TResult> collation)
        {
            return value.Bind(firstValue => transformation(firstValue).Bind(secondValue => Maybe.Just(collation(firstValue, secondValue))));
        }

        #endregion
    }
}