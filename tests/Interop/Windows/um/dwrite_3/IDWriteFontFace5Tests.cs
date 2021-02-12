// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDWriteFontFace5" /> struct.</summary>
    public static unsafe class IDWriteFontFace5Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteFontFace5" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDWriteFontFace5).GUID, Is.EqualTo(IID_IDWriteFontFace5));
        }

        /// <summary>Validates that the <see cref="IDWriteFontFace5" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDWriteFontFace5>(), Is.EqualTo(sizeof(IDWriteFontFace5)));
        }

        /// <summary>Validates that the <see cref="IDWriteFontFace5" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDWriteFontFace5).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDWriteFontFace5" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDWriteFontFace5), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDWriteFontFace5), Is.EqualTo(4));
            }
        }
    }
}
