// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CIEXYZTRIPLE" /> struct.</summary>
    public static unsafe class CIEXYZTRIPLETests
    {
        /// <summary>Validates that the <see cref="CIEXYZTRIPLE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CIEXYZTRIPLE>(), Is.EqualTo(sizeof(CIEXYZTRIPLE)));
        }

        /// <summary>Validates that the <see cref="CIEXYZTRIPLE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CIEXYZTRIPLE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CIEXYZTRIPLE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CIEXYZTRIPLE), Is.EqualTo(36));
        }
    }
}
