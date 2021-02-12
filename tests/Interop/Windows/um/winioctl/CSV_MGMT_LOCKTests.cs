// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CSV_MGMT_LOCK" /> struct.</summary>
    public static unsafe class CSV_MGMT_LOCKTests
    {
        /// <summary>Validates that the <see cref="CSV_MGMT_LOCK" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CSV_MGMT_LOCK>(), Is.EqualTo(sizeof(CSV_MGMT_LOCK)));
        }

        /// <summary>Validates that the <see cref="CSV_MGMT_LOCK" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CSV_MGMT_LOCK).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CSV_MGMT_LOCK" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CSV_MGMT_LOCK), Is.EqualTo(4));
        }
    }
}
