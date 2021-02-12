// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PARTITION_INFORMATION_EX" /> struct.</summary>
    public static unsafe class PARTITION_INFORMATION_EXTests
    {
        /// <summary>Validates that the <see cref="PARTITION_INFORMATION_EX" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PARTITION_INFORMATION_EX>(), Is.EqualTo(sizeof(PARTITION_INFORMATION_EX)));
        }

        /// <summary>Validates that the <see cref="PARTITION_INFORMATION_EX" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PARTITION_INFORMATION_EX).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PARTITION_INFORMATION_EX" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PARTITION_INFORMATION_EX), Is.EqualTo(144));
        }
    }
}
