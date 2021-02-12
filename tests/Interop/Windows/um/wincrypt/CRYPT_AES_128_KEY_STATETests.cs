// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CRYPT_AES_128_KEY_STATE" /> struct.</summary>
    public static unsafe class CRYPT_AES_128_KEY_STATETests
    {
        /// <summary>Validates that the <see cref="CRYPT_AES_128_KEY_STATE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CRYPT_AES_128_KEY_STATE>(), Is.EqualTo(sizeof(CRYPT_AES_128_KEY_STATE)));
        }

        /// <summary>Validates that the <see cref="CRYPT_AES_128_KEY_STATE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CRYPT_AES_128_KEY_STATE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CRYPT_AES_128_KEY_STATE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CRYPT_AES_128_KEY_STATE), Is.EqualTo(400));
        }
    }
}
