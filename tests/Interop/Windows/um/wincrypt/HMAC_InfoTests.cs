// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HMAC_Info" /> struct.</summary>
    public static unsafe class HMAC_InfoTests
    {
        /// <summary>Validates that the <see cref="HMAC_Info" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HMAC_Info>(), Is.EqualTo(sizeof(HMAC_Info)));
        }

        /// <summary>Validates that the <see cref="HMAC_Info" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HMAC_Info).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HMAC_Info" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(HMAC_Info), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(HMAC_Info), Is.EqualTo(20));
            }
        }
    }
}
