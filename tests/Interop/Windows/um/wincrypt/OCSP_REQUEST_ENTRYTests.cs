// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="OCSP_REQUEST_ENTRY" /> struct.</summary>
    public static unsafe class OCSP_REQUEST_ENTRYTests
    {
        /// <summary>Validates that the <see cref="OCSP_REQUEST_ENTRY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<OCSP_REQUEST_ENTRY>(), Is.EqualTo(sizeof(OCSP_REQUEST_ENTRY)));
        }

        /// <summary>Validates that the <see cref="OCSP_REQUEST_ENTRY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(OCSP_REQUEST_ENTRY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="OCSP_REQUEST_ENTRY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(OCSP_REQUEST_ENTRY), Is.EqualTo(88));
            }
            else
            {
                Assert.That(sizeof(OCSP_REQUEST_ENTRY), Is.EqualTo(44));
            }
        }
    }
}
