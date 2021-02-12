// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="EMRBITBLT" /> struct.</summary>
    public static unsafe class EMRBITBLTTests
    {
        /// <summary>Validates that the <see cref="EMRBITBLT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<EMRBITBLT>(), Is.EqualTo(sizeof(EMRBITBLT)));
        }

        /// <summary>Validates that the <see cref="EMRBITBLT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(EMRBITBLT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="EMRBITBLT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(EMRBITBLT), Is.EqualTo(100));
        }
    }
}
