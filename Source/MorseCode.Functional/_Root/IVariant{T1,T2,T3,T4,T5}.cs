﻿#region License

// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IVariant{T1,T2,T3,T4,T5}.cs" company="MorseCode Software">
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
    /// An interface representing a variant (or discriminated union) type which may hold one value of any of the types <typeparamref name="T1"/>, <typeparamref name="T2"/>, <typeparamref name="T3"/>, <typeparamref name="T4"/>, or <typeparamref name="T5"/>.
    /// </summary>
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
    [ContractClass(typeof(VariantInterfaceContract<,,,,>))]
    public interface IVariant<out T1, out T2, out T3, out T4, out T5> : IVariantWithCommon<object, T1, T2, T3, T4, T5>
    {
    }
}