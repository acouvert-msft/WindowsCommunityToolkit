﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#nullable enable

namespace Microsoft.Toolkit.Diagnostics
{
    /// <summary>
    /// Helper methods to verify conditions when running code.
    /// </summary>
    public static partial class Guard
    {
        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must be <see langword="null"/> or empty.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is neither <see langword="null"/> nor empty.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNullOrEmpty(string? text, string name)
        {
            if (!string.IsNullOrEmpty(text))
            {
                ThrowHelper.ThrowArgumentExceptionForIsNullOrEmpty(text, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must not be <see langword="null"/> or empty.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is <see langword="null"/> or empty.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotNullOrEmpty([NotNull] string? text, string name)
        {
            if (string.IsNullOrEmpty(text))
            {
                ThrowHelper.ThrowArgumentExceptionForIsNotNullOrEmpty(text, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must be <see langword="null"/> or whitespace.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is neither <see langword="null"/> nor whitespace.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNullOrWhitespace(string? text, string name)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                ThrowHelper.ThrowArgumentExceptionForIsNullOrWhitespace(text, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must not be <see langword="null"/> or whitespace.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is <see langword="null"/> or whitespace.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotNullOrWhitespace([NotNull] string? text, string name)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                ThrowHelper.ThrowArgumentExceptionForIsNotNullOrWhitespace(text, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must be empty.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is empty.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsEmpty(string text, string name)
        {
            if (text.Length != 0)
            {
                ThrowHelper.ThrowArgumentExceptionForIsEmpty(text, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must not be empty.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is empty.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotEmpty(string text, string name)
        {
            if (text.Length == 0)
            {
                ThrowHelper.ThrowArgumentExceptionForIsNotEmpty(text, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must be whitespace.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is neither <see langword="null"/> nor whitespace.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsWhitespace(string text, string name)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                ThrowHelper.ThrowArgumentExceptionForIsWhitespace(text, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must not be <see langword="null"/> or whitespace.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if <paramref name="text"/> is <see langword="null"/> or whitespace.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotWhitespace(string text, string name)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                ThrowHelper.ThrowArgumentExceptionForIsNotWhitespace(text, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must have a size of a specified value.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is != <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo(string text, int size, string name)
        {
            if (text.Length != size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo(text, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must have a size not equal to a specified value.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is == <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeNotEqualTo(string text, int size, string name)
        {
            if (text.Length == size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeNotEqualTo(text, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must have a size over a specified value.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is &lt;= <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeGreaterThan(string text, int size, string name)
        {
            if (text.Length <= size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeGreaterThan(text, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must have a size of at least specified value.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is &lt; <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeGreaterThanOrEqualTo(string text, int size, string name)
        {
            if (text.Length < size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeGreaterThanOrEqualTo(text, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must have a size of less than a specified value.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is >= <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThan(string text, int size, string name)
        {
            if (text.Length >= size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeLessThan(text, size, name);
            }
        }

        /// <summary>
        /// Asserts that the input <see cref="string"/> instance must have a size of less than or equal to a specified value.
        /// </summary>
        /// <param name="text">The input <see cref="string"/> instance to check the size for.</param>
        /// <param name="size">The target size to test.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="text"/> is > <paramref name="size"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo(string text, int size, string name)
        {
            if (text.Length > size)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeLessThanOrEqualTo(text, size, name);
            }
        }

        /// <summary>
        /// Asserts that the source <see cref="string"/> instance must have the same size of a destination <see cref="string"/> instance.
        /// </summary>
        /// <param name="source">The source <see cref="string"/> instance to check the size for.</param>
        /// <param name="destination">The destination <see cref="string"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="source"/> is != the one of <paramref name="destination"/>.</exception>
        /// <remarks>The <see cref="string"/> type is immutable, but the name of this API is kept for consistency with the other overloads.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeEqualTo(string source, string destination, string name)
        {
            if (source.Length != destination.Length)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeEqualTo(source, destination, name);
            }
        }

        /// <summary>
        /// Asserts that the source <see cref="string"/> instance must have a size of less than or equal to that of a destination <see cref="string"/> instance.
        /// </summary>
        /// <param name="source">The source <see cref="string"/> instance to check the size for.</param>
        /// <param name="destination">The destination <see cref="string"/> instance to check the size for.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentException">Thrown if the size of <paramref name="source"/> is > the one of <paramref name="destination"/>.</exception>
        /// <remarks>The <see cref="string"/> type is immutable, but the name of this API is kept for consistency with the other overloads.</remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void HasSizeLessThanOrEqualTo(string source, string destination, string name)
        {
            if (source.Length > destination.Length)
            {
                ThrowHelper.ThrowArgumentExceptionForHasSizeLessThanOrEqualTo(source, destination, name);
            }
        }

        /// <summary>
        /// Asserts that the input index is valid for a given <see cref="string"/> instance.
        /// </summary>
        /// <param name="index">The input index to be used to access <paramref name="text"/>.</param>
        /// <param name="text">The input <see cref="string"/> instance to use to validate <paramref name="index"/>.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is not valid to access <paramref name="text"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsInRangeFor(int index, string text, string name)
        {
            if ((uint)index >= (uint)text.Length)
            {
                ThrowHelper.ThrowArgumentOutOfRangeExceptionForIsInRangeFor(index, text, name);
            }
        }

        /// <summary>
        /// Asserts that the input index is not valid for a given <see cref="string"/> instance.
        /// </summary>
        /// <param name="index">The input index to be used to access <paramref name="text"/>.</param>
        /// <param name="text">The input <see cref="string"/> instance to use to validate <paramref name="index"/>.</param>
        /// <param name="name">The name of the input parameter being tested.</param>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="index"/> is valid to access <paramref name="text"/>.</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void IsNotInRangeFor(int index, string text, string name)
        {
            if ((uint)index < (uint)text.Length)
            {
                ThrowHelper.ThrowArgumentOutOfRangeExceptionForIsNotInRangeFor(index, text, name);
            }
        }
    }
}
