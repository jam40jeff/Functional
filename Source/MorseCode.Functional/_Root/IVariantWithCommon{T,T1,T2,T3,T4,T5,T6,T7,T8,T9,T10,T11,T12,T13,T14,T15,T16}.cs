#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IVariantWithCommon{T,T1,T2,T3,T4,T5,T6,T7,T8,T9,T10,T11,T12,T13,T14,T15,T16}.cs" company="MorseCode Software">
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
    /// An interface representing a variant (or discriminated union) type which may hold one value of any of the types <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, <typeparamref name="T5"/>, <typeparamref name="T6"/>, <typeparamref name="T7"/>, <typeparamref name="T8"/>, <typeparamref name="T9"/>, <typeparamref name="T10"/>, <typeparamref name="T11"/>, <typeparamref name="T12"/>, <typeparamref name="T13"/>, <typeparamref name="T14"/>, <typeparamref name="T15"/>, or <typeparamref name="T16"/>
    /// all of which inherit from or implement a common type <typeparamref name="T"/>.
    /// </summary>
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
    [ContractClass(typeof(VariantWithCommonInterfaceContract<,,,,,,,,,,,,,,,,>))]
    public interface IVariantWithCommon<out T, out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16> : IVariantWithCommon<T>
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
        #region Public Methods and Operators

        /// <summary>
        /// Executes an action based on which value is contained in the variant (or discriminated union).
        /// </summary>
        /// <param name="first">
        /// The action to run if the value stored in the variant (or discriminated union) is of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </param>
        /// <param name="second">
        /// The action to run if the value stored in the variant (or discriminated union) is of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </param>
        /// <param name="third">
        /// The action to run if the value stored in the variant (or discriminated union) is of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </param>
        /// <param name="fourth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </param>
        /// <param name="fifth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </param>
        /// <param name="sixth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </param>
        /// <param name="seventh">
        /// The action to run if the value stored in the variant (or discriminated union) is of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </param>
        /// <param name="eighth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </param>
        /// <param name="ninth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </param>
        /// <param name="tenth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </param>
        /// <param name="eleventh">
        /// The action to run if the value stored in the variant (or discriminated union) is of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </param>
        /// <param name="twelfth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </param>
        /// <param name="thirteenth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the thirteenth possible variant value (of type <typeparamref name="T13"/>).
        /// </param>
        /// <param name="fourteenth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the fourteenth possible variant value (of type <typeparamref name="T14"/>).
        /// </param>
        /// <param name="fifteenth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the fifteenth possible variant value (of type <typeparamref name="T15"/>).
        /// </param>
        /// <param name="sixteenth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the sixteenth possible variant value (of type <typeparamref name="T16"/>).
        /// </param>
        void Match(Action<T1> first, Action<T2> second, Action<T3> third, Action<T4> fourth, Action<T5> fifth, Action<T6> sixth, Action<T7> seventh, Action<T8> eighth, Action<T9> ninth, Action<T10> tenth, Action<T11> eleventh, Action<T12> twelfth, Action<T13> thirteenth, Action<T14> fourteenth, Action<T15> fifteenth, Action<T16> sixteenth);

        /// <summary>
        /// Executes a function based on which value is contained in the variant (or discriminated union).
        /// </summary>
        /// <param name="first">
        /// The function to run if the value stored in the variant (or discriminated union) is of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </param>
        /// <param name="second">
        /// The function to run if the value stored in the variant (or discriminated union) is of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </param>
        /// <param name="third">
        /// The function to run if the value stored in the variant (or discriminated union) is of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </param>
        /// <param name="fourth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </param>
        /// <param name="fifth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </param>
        /// <param name="sixth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </param>
        /// <param name="seventh">
        /// The function to run if the value stored in the variant (or discriminated union) is of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </param>
        /// <param name="eighth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </param>
        /// <param name="ninth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </param>
        /// <param name="tenth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </param>
        /// <param name="eleventh">
        /// The function to run if the value stored in the variant (or discriminated union) is of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </param>
        /// <param name="twelfth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </param>
        /// <param name="thirteenth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the thirteenth possible variant value (of type <typeparamref name="T13"/>).
        /// </param>
        /// <param name="fourteenth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the fourteenth possible variant value (of type <typeparamref name="T14"/>).
        /// </param>
        /// <param name="fifteenth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the fifteenth possible variant value (of type <typeparamref name="T15"/>).
        /// </param>
        /// <param name="sixteenth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the sixteenth possible variant value (of type <typeparamref name="T16"/>).
        /// </param>
        /// <typeparam name="TResult">
        /// The type of the result.
        /// </typeparam>
        /// <returns>
        /// The result of type <typeparamref name="TResult"/> of the function executed.
        /// </returns>
        TResult Match<TResult>(Func<T1, TResult> first, Func<T2, TResult> second, Func<T3, TResult> third, Func<T4, TResult> fourth, Func<T5, TResult> fifth, Func<T6, TResult> sixth, Func<T7, TResult> seventh, Func<T8, TResult> eighth, Func<T9, TResult> ninth, Func<T10, TResult> tenth, Func<T11, TResult> eleventh, Func<T12, TResult> twelfth, Func<T13, TResult> thirteenth, Func<T14, TResult> fourteenth, Func<T15, TResult> fifteenth, Func<T16, TResult> sixteenth);

        /// <summary>
        /// Executes an action based on which value is contained in the variant (or discriminated union).
        /// </summary>
        /// <param name="otherwise">
        /// The action to execute if the value stored in the variant (or discriminated union) is of a possible variant value which was passed a corresponding <c>null</c> delegate.
        /// </param>
        /// <param name="first">
        /// The action to run if the value stored in the variant (or discriminated union) is of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </param>
        /// <param name="second">
        /// The action to run if the value stored in the variant (or discriminated union) is of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </param>
        /// <param name="third">
        /// The action to run if the value stored in the variant (or discriminated union) is of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </param>
        /// <param name="fourth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </param>
        /// <param name="fifth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </param>
        /// <param name="sixth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </param>
        /// <param name="seventh">
        /// The action to run if the value stored in the variant (or discriminated union) is of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </param>
        /// <param name="eighth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </param>
        /// <param name="ninth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </param>
        /// <param name="tenth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </param>
        /// <param name="eleventh">
        /// The action to run if the value stored in the variant (or discriminated union) is of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </param>
        /// <param name="twelfth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </param>
        /// <param name="thirteenth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the thirteenth possible variant value (of type <typeparamref name="T13"/>).
        /// </param>
        /// <param name="fourteenth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the fourteenth possible variant value (of type <typeparamref name="T14"/>).
        /// </param>
        /// <param name="fifteenth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the fifteenth possible variant value (of type <typeparamref name="T15"/>).
        /// </param>
        /// <param name="sixteenth">
        /// The action to run if the value stored in the variant (or discriminated union) is of the sixteenth possible variant value (of type <typeparamref name="T16"/>).
        /// </param>
        void MatchSome(Action otherwise, Action<T1> first = null, Action<T2> second = null, Action<T3> third = null, Action<T4> fourth = null, Action<T5> fifth = null, Action<T6> sixth = null, Action<T7> seventh = null, Action<T8> eighth = null, Action<T9> ninth = null, Action<T10> tenth = null, Action<T11> eleventh = null, Action<T12> twelfth = null, Action<T13> thirteenth = null, Action<T14> fourteenth = null, Action<T15> fifteenth = null, Action<T16> sixteenth = null);

        /// <summary>
        /// Executes a function based on which value is contained in the variant (or discriminated union).
        /// </summary>
        /// <param name="otherwise">
        /// The function to execute if the value stored in the variant (or discriminated union) is of a possible variant value which was passed a corresponding <c>null</c> delegate.
        /// </param>
        /// <param name="first">
        /// The function to run if the value stored in the variant (or discriminated union) is of the first possible variant value (of type <typeparamref name="T1"/>).
        /// </param>
        /// <param name="second">
        /// The function to run if the value stored in the variant (or discriminated union) is of the second possible variant value (of type <typeparamref name="T2"/>).
        /// </param>
        /// <param name="third">
        /// The function to run if the value stored in the variant (or discriminated union) is of the third possible variant value (of type <typeparamref name="T3"/>).
        /// </param>
        /// <param name="fourth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the fourth possible variant value (of type <typeparamref name="T4"/>).
        /// </param>
        /// <param name="fifth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the fifth possible variant value (of type <typeparamref name="T5"/>).
        /// </param>
        /// <param name="sixth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the sixth possible variant value (of type <typeparamref name="T6"/>).
        /// </param>
        /// <param name="seventh">
        /// The function to run if the value stored in the variant (or discriminated union) is of the seventh possible variant value (of type <typeparamref name="T7"/>).
        /// </param>
        /// <param name="eighth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the eighth possible variant value (of type <typeparamref name="T8"/>).
        /// </param>
        /// <param name="ninth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the ninth possible variant value (of type <typeparamref name="T9"/>).
        /// </param>
        /// <param name="tenth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the tenth possible variant value (of type <typeparamref name="T10"/>).
        /// </param>
        /// <param name="eleventh">
        /// The function to run if the value stored in the variant (or discriminated union) is of the eleventh possible variant value (of type <typeparamref name="T11"/>).
        /// </param>
        /// <param name="twelfth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the twelfth possible variant value (of type <typeparamref name="T12"/>).
        /// </param>
        /// <param name="thirteenth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the thirteenth possible variant value (of type <typeparamref name="T13"/>).
        /// </param>
        /// <param name="fourteenth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the fourteenth possible variant value (of type <typeparamref name="T14"/>).
        /// </param>
        /// <param name="fifteenth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the fifteenth possible variant value (of type <typeparamref name="T15"/>).
        /// </param>
        /// <param name="sixteenth">
        /// The function to run if the value stored in the variant (or discriminated union) is of the sixteenth possible variant value (of type <typeparamref name="T16"/>).
        /// </param>
        /// <typeparam name="TResult">
        /// The type of the result.
        /// </typeparam>
        /// <returns>
        /// The result of type <typeparamref name="TResult"/> of the function executed.
        /// </returns>
        TResult MatchSome<TResult>(Func<TResult> otherwise, Func<T1, TResult> first = null, Func<T2, TResult> second = null, Func<T3, TResult> third = null, Func<T4, TResult> fourth = null, Func<T5, TResult> fifth = null, Func<T6, TResult> sixth = null, Func<T7, TResult> seventh = null, Func<T8, TResult> eighth = null, Func<T9, TResult> ninth = null, Func<T10, TResult> tenth = null, Func<T11, TResult> eleventh = null, Func<T12, TResult> twelfth = null, Func<T13, TResult> thirteenth = null, Func<T14, TResult> fourteenth = null, Func<T15, TResult> fifteenth = null, Func<T16, TResult> sixteenth = null);

        #endregion
    }
}