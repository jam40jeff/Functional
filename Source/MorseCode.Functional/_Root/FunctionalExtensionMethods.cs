#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FunctionalExtensionMethods.cs" company="MorseCode Software">
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

    public static class FunctionalExtensionMethods
    {
        #region Public Methods and Operators

        public static Func<T1, T3> Compose<T1, T2, T3>(this Func<T2, T3> f, Func<T1, T2> g)
        {
            return a => f(g(a));
        }

        public static Func<T1, T2, T4> Compose<T1, T2, T3, T4>(this Func<T3, T4> f, Func<T1, T2, T3> g)
        {
            return (a, b) => f(g(a, b));
        }

        //TODO: finish Compose

        public static Func<T1, Func<T2, TResult>> Curry<T1, T2, TResult>(this Func<T1, T2, TResult> func)
        {
            return a => b => func(a, b);
        }

        public static Func<T1, Func<T2, Func<T3, TResult>>> Curry<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func)
        {
            return a => b => c => func(a, b, c);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>> Curry<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func)
        {
            return a => b => c => d => func(a, b, c, d);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>> Curry<T1, T2, T3, T4, T5, TResult>(this Func<T1, T2, T3, T4, T5, TResult> func)
        {
            return a => b => c => d => e => func(a, b, c, d, e);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>> Curry<T1, T2, T3, T4, T5, T6, TResult>(this Func<T1, T2, T3, T4, T5, T6, TResult> func)
        {
            return a => b => c => d => e => f => func(a, b, c, d, e, f);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, TResult> func)
        {
            return a => b => c => d => e => f => g => func(a, b, c, d, e, f, g);
        }

        public static Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>> Curry<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(this Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> func)
        {
            return a => b => c => d => e => f => g => h => func(a, b, c, d, e, f, g, h);
        }

        public static Func<T2, T1, TResult> Flip<T1, T2, TResult>(this Func<T1, T2, TResult> func)
        {
            return (a, b) => func(b, a);
        }

        public static Func<T2, Func<T1, TResult>> Flip<T1, T2, TResult>(this Func<T1, Func<T2, TResult>> func)
        {
            return b => a => func(a)(b);
        }

        public static Func<TResult> PartialApply<T1, TResult>(this Func<T1, TResult> func, T1 firstArgument)
        {
            return () => func(firstArgument);
        }

        public static Func<T2, TResult> PartialApply<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 firstArgument)
        {
            return a => func(firstArgument, a);
        }

        public static Func<TResult> PartialApply<T1, T2, TResult>(this Func<T1, T2, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return () => func(firstArgument, secondArgument);
        }

        public static Func<T2, T3, TResult> PartialApply<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 firstArgument)
        {
            return (a, b) => func(firstArgument, a, b);
        }

        public static Func<T3, TResult> PartialApply<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return a => func(firstArgument, secondArgument, a);
        }

        public static Func<TResult> PartialApply<T1, T2, T3, TResult>(this Func<T1, T2, T3, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument);
        }

        public static Func<T2, T3, T4, TResult> PartialApply<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 firstArgument)
        {
            return (a, b, c) => func(firstArgument, a, b, c);
        }

        public static Func<T3, T4, TResult> PartialApply<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 firstArgument, T2 secondArgument)
        {
            return (a, b) => func(firstArgument, secondArgument, a, b);
        }

        public static Func<T4, TResult> PartialApply<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument)
        {
            return a => func(firstArgument, secondArgument, thirdArgument, a);
        }

        public static Func<TResult> PartialApply<T1, T2, T3, T4, TResult>(this Func<T1, T2, T3, T4, TResult> func, T1 firstArgument, T2 secondArgument, T3 thirdArgument, T4 fourthArgument)
        {
            return () => func(firstArgument, secondArgument, thirdArgument, fourthArgument);
        }

        //TODO: finish PartialApply

        #endregion
    }
}