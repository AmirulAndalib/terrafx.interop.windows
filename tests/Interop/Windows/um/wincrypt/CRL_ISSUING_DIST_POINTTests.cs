// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CRL_ISSUING_DIST_POINT" /> struct.</summary>
    public static unsafe class CRL_ISSUING_DIST_POINTTests
    {
        /// <summary>Validates that the <see cref="CRL_ISSUING_DIST_POINT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CRL_ISSUING_DIST_POINT>(), Is.EqualTo(sizeof(CRL_ISSUING_DIST_POINT)));
        }

        /// <summary>Validates that the <see cref="CRL_ISSUING_DIST_POINT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CRL_ISSUING_DIST_POINT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CRL_ISSUING_DIST_POINT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CRL_ISSUING_DIST_POINT), Is.EqualTo(64));
            }
            else
            {
                Assert.That(sizeof(CRL_ISSUING_DIST_POINT), Is.EqualTo(36));
            }
        }
    }
}
