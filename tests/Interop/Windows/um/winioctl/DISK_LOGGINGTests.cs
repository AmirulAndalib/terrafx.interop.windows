// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DISK_LOGGING" /> struct.</summary>
    public static unsafe class DISK_LOGGINGTests
    {
        /// <summary>Validates that the <see cref="DISK_LOGGING" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DISK_LOGGING>(), Is.EqualTo(sizeof(DISK_LOGGING)));
        }

        /// <summary>Validates that the <see cref="DISK_LOGGING" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DISK_LOGGING).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DISK_LOGGING" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DISK_LOGGING), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(DISK_LOGGING), Is.EqualTo(12));
            }
        }
    }
}
