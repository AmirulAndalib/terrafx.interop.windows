// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PARTITION_INFORMATION_MBR" /> struct.</summary>
    public static unsafe class PARTITION_INFORMATION_MBRTests
    {
        /// <summary>Validates that the <see cref="PARTITION_INFORMATION_MBR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PARTITION_INFORMATION_MBR>(), Is.EqualTo(sizeof(PARTITION_INFORMATION_MBR)));
        }

        /// <summary>Validates that the <see cref="PARTITION_INFORMATION_MBR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PARTITION_INFORMATION_MBR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PARTITION_INFORMATION_MBR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PARTITION_INFORMATION_MBR), Is.EqualTo(24));
        }
    }
}
