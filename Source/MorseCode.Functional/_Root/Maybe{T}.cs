#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Maybe{T}.cs" company="MorseCode Software">
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

    internal class Maybe<T> : IMaybe<T>
    {
        #region Static Fields

        public static readonly Maybe<T> Nothing = new Maybe<T>();

        #endregion

        #region Fields

        private readonly bool hasValue;

        private readonly IMaybe<T> thisMaybe;

        private readonly T value;

        #endregion

        #region Constructors and Destructors

        internal Maybe(T value)
        {
            this.thisMaybe = this;

            this.hasValue = true;
            this.value = value;
        }

        private Maybe()
        {
            this.thisMaybe = this;
        }

        #endregion

        #region Public Methods and Operators

        public override string ToString()
        {
            return this.thisMaybe.Switch(v => "Just: " + v.SafeToString(), () => "Nothing");
        }

        #endregion

        #region Explicit Interface Methods

        void IMaybe<T>.Switch<TReturn>(Action<T> hasValueAction, Action nothingAction)
        {
            if (this.hasValue)
            {
                hasValueAction(this.value);
            }
            else
            {
                nothingAction();
            }
        }

        TReturn IMaybe<T>.Switch<TReturn>(Func<T, TReturn> hasValueFunc, Func<TReturn> nothingFunc)
        {
            return this.hasValue ? hasValueFunc(this.value) : nothingFunc();
        }

        #endregion
    }
}