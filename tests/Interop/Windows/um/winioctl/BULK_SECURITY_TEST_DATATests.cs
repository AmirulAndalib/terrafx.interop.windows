// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="BULK_SECURITY_TEST_DATA" /> struct.</summary>
    public static unsafe class BULK_SECURITY_TEST_DATATests
    {
        /// <summary>Validates that the <see cref="BULK_SECURITY_TEST_DATA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<BULK_SECURITY_TEST_DATA>(), Is.EqualTo(sizeof(BULK_SECURITY_TEST_DATA)));
        }

        /// <summary>Validates that the <see cref="BULK_SECURITY_TEST_DATA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(BULK_SECURITY_TEST_DATA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="BULK_SECURITY_TEST_DATA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(BULK_SECURITY_TEST_DATA), Is.EqualTo(8));
        }
    }
}
