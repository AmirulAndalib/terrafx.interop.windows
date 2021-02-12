// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D2D_MATRIX_5X4_F" /> struct.</summary>
    public static unsafe class D2D_MATRIX_5X4_FTests
    {
        /// <summary>Validates that the <see cref="D2D_MATRIX_5X4_F" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D2D_MATRIX_5X4_F>(), Is.EqualTo(sizeof(D2D_MATRIX_5X4_F)));
        }

        /// <summary>Validates that the <see cref="D2D_MATRIX_5X4_F" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D2D_MATRIX_5X4_F).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D2D_MATRIX_5X4_F" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D2D_MATRIX_5X4_F), Is.EqualTo(80));
        }
    }
}
