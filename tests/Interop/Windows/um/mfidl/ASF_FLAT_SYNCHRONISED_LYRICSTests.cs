// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ASF_FLAT_SYNCHRONISED_LYRICS" /> struct.</summary>
    public static unsafe class ASF_FLAT_SYNCHRONISED_LYRICSTests
    {
        /// <summary>Validates that the <see cref="ASF_FLAT_SYNCHRONISED_LYRICS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ASF_FLAT_SYNCHRONISED_LYRICS>(), Is.EqualTo(sizeof(ASF_FLAT_SYNCHRONISED_LYRICS)));
        }

        /// <summary>Validates that the <see cref="ASF_FLAT_SYNCHRONISED_LYRICS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ASF_FLAT_SYNCHRONISED_LYRICS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ASF_FLAT_SYNCHRONISED_LYRICS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(ASF_FLAT_SYNCHRONISED_LYRICS), Is.EqualTo(6));
        }
    }
}
