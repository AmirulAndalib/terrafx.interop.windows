// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DISK_GEOMETRY" /> struct.</summary>
    public static unsafe class DISK_GEOMETRYTests
    {
        /// <summary>Validates that the <see cref="DISK_GEOMETRY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DISK_GEOMETRY>(), Is.EqualTo(sizeof(DISK_GEOMETRY)));
        }

        /// <summary>Validates that the <see cref="DISK_GEOMETRY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DISK_GEOMETRY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DISK_GEOMETRY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DISK_GEOMETRY), Is.EqualTo(24));
        }
    }
}
