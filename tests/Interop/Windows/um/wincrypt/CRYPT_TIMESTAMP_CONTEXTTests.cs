// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CRYPT_TIMESTAMP_CONTEXT" /> struct.</summary>
    public static unsafe class CRYPT_TIMESTAMP_CONTEXTTests
    {
        /// <summary>Validates that the <see cref="CRYPT_TIMESTAMP_CONTEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CRYPT_TIMESTAMP_CONTEXT>(), Is.EqualTo(sizeof(CRYPT_TIMESTAMP_CONTEXT)));
        }

        /// <summary>Validates that the <see cref="CRYPT_TIMESTAMP_CONTEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CRYPT_TIMESTAMP_CONTEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CRYPT_TIMESTAMP_CONTEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CRYPT_TIMESTAMP_CONTEXT), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(CRYPT_TIMESTAMP_CONTEXT), Is.EqualTo(12));
            }
        }
    }
}
