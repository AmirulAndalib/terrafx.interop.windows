// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TAPE_GET_STATISTICS" /> struct.</summary>
    public static unsafe class TAPE_GET_STATISTICSTests
    {
        /// <summary>Validates that the <see cref="TAPE_GET_STATISTICS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TAPE_GET_STATISTICS>(), Is.EqualTo(sizeof(TAPE_GET_STATISTICS)));
        }

        /// <summary>Validates that the <see cref="TAPE_GET_STATISTICS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TAPE_GET_STATISTICS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TAPE_GET_STATISTICS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TAPE_GET_STATISTICS), Is.EqualTo(4));
        }
    }
}
