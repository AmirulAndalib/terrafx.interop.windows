// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MFCONTENTPROTECTIONDEVICE_INPUT_DATA" /> struct.</summary>
    public static unsafe class MFCONTENTPROTECTIONDEVICE_INPUT_DATATests
    {
        /// <summary>Validates that the <see cref="MFCONTENTPROTECTIONDEVICE_INPUT_DATA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MFCONTENTPROTECTIONDEVICE_INPUT_DATA>(), Is.EqualTo(sizeof(MFCONTENTPROTECTIONDEVICE_INPUT_DATA)));
        }

        /// <summary>Validates that the <see cref="MFCONTENTPROTECTIONDEVICE_INPUT_DATA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MFCONTENTPROTECTIONDEVICE_INPUT_DATA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MFCONTENTPROTECTIONDEVICE_INPUT_DATA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MFCONTENTPROTECTIONDEVICE_INPUT_DATA), Is.EqualTo(20));
        }
    }
}
