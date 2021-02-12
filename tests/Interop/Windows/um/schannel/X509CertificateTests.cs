// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="X509Certificate" /> struct.</summary>
    public static unsafe class X509CertificateTests
    {
        /// <summary>Validates that the <see cref="X509Certificate" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<X509Certificate>(), Is.EqualTo(sizeof(X509Certificate)));
        }

        /// <summary>Validates that the <see cref="X509Certificate" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(X509Certificate).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="X509Certificate" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(X509Certificate), Is.EqualTo(64));
            }
            else
            {
                Assert.That(sizeof(X509Certificate), Is.EqualTo(52));
            }
        }
    }
}
