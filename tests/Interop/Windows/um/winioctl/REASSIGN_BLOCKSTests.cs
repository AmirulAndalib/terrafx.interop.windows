// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="REASSIGN_BLOCKS" /> struct.</summary>
    public static unsafe class REASSIGN_BLOCKSTests
    {
        /// <summary>Validates that the <see cref="REASSIGN_BLOCKS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<REASSIGN_BLOCKS>(), Is.EqualTo(sizeof(REASSIGN_BLOCKS)));
        }

        /// <summary>Validates that the <see cref="REASSIGN_BLOCKS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(REASSIGN_BLOCKS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="REASSIGN_BLOCKS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(REASSIGN_BLOCKS), Is.EqualTo(8));
        }
    }
}
