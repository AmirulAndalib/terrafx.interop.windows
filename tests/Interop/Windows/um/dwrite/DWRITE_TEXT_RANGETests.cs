// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DWRITE_TEXT_RANGE" /> struct.</summary>
    public static unsafe class DWRITE_TEXT_RANGETests
    {
        /// <summary>Validates that the <see cref="DWRITE_TEXT_RANGE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DWRITE_TEXT_RANGE>(), Is.EqualTo(sizeof(DWRITE_TEXT_RANGE)));
        }

        /// <summary>Validates that the <see cref="DWRITE_TEXT_RANGE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DWRITE_TEXT_RANGE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DWRITE_TEXT_RANGE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DWRITE_TEXT_RANGE), Is.EqualTo(8));
        }
    }
}
