// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CRYPT_RC2_CBC_PARAMETERS" /> struct.</summary>
    public static unsafe class CRYPT_RC2_CBC_PARAMETERSTests
    {
        /// <summary>Validates that the <see cref="CRYPT_RC2_CBC_PARAMETERS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CRYPT_RC2_CBC_PARAMETERS>(), Is.EqualTo(sizeof(CRYPT_RC2_CBC_PARAMETERS)));
        }

        /// <summary>Validates that the <see cref="CRYPT_RC2_CBC_PARAMETERS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CRYPT_RC2_CBC_PARAMETERS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CRYPT_RC2_CBC_PARAMETERS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CRYPT_RC2_CBC_PARAMETERS), Is.EqualTo(16));
        }
    }
}
