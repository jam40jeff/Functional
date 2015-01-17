#region License

// Copyright 2014 MorseCode Software
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//     http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

namespace MorseCode.Functional.DiscriminatedUnion
{
    using System;
    using System.Diagnostics.Contracts;

    [ContractClassFor(typeof(IDiscriminatedUnion<,,>))]
    internal abstract class DiscriminatedUnionInterfaceContract<TCommon, T1, T2> : IDiscriminatedUnion<TCommon, T1, T2>
        where T1 : TCommon
        where T2 : TCommon
        where TCommon : class
    {
        /// <summary>
        /// Gets a value indicating whether the discriminated union is holding a value of the type <typeparamref name="T1" />.
        /// </summary>
        public bool IsFirst
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Gets a value indicating whether the discriminated union is holding a value of the type <typeparamref name="T2" />.
        /// </summary>
        public bool IsSecond
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T1" /> if <see cref="IsFirst"/> is <c>true</c>, otherwise returns the default value for type <typeparamref name="T1" />.
        /// </summary>
        public T1 First
        {
            get
            {
                return default(T1);
            }
        }

        /// <summary>
        /// Gets the value of type <typeparamref name="T2" /> if <see cref="IsSecond"/> is <c>true</c>, otherwise returns the default value for type <typeparamref name="T2" />.
        /// </summary>
        public T2 Second
        {
            get
            {
                return default(T2);
            }
        }

        /// <summary>
        /// Gets the value as <typeparamref name="TCommon" /> regardless of which of the two values are held in the discriminated union.
        /// </summary>
        public TCommon Value
        {
            get
            {
                return default(TCommon);
            }
        }

        /// <summary>
        /// Executes an action based on which value is contained in the discriminated union.
        /// </summary>
        /// <param name="first">
        /// The action to run if <see cref="IsFirst"/> is <c>true</c>.
        /// </param>
        /// <param name="second">
        /// The action to run if <see cref="IsSecond"/> is <c>true</c>.
        /// </param>
        public void Switch(Action<T1> first, Action<T2> second)
        {
        }

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
        public TResult Switch<TResult>(Func<T1, TResult> first, Func<T2, TResult> second)
        {
            return default(TResult);
        }
    }
}