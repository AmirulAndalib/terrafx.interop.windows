// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CRYPTNET_URL_CACHE_RESPONSE_INFO" /> struct.</summary>
    public static unsafe class CRYPTNET_URL_CACHE_RESPONSE_INFOTests
    {
        /// <summary>Validates that the <see cref="CRYPTNET_URL_CACHE_RESPONSE_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CRYPTNET_URL_CACHE_RESPONSE_INFO>(), Is.EqualTo(sizeof(CRYPTNET_URL_CACHE_RESPONSE_INFO)));
        }

        /// <summary>Validates that the <see cref="CRYPTNET_URL_CACHE_RESPONSE_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CRYPTNET_URL_CACHE_RESPONSE_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CRYPTNET_URL_CACHE_RESPONSE_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CRYPTNET_URL_CACHE_RESPONSE_INFO), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(CRYPTNET_URL_CACHE_RESPONSE_INFO), Is.EqualTo(28));
            }
        }
    }
}
