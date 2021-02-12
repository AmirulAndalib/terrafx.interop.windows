// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD" /> struct.</summary>
    public static unsafe class DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORDTests
    {
        /// <summary>Validates that the <see cref="DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD>(), Is.EqualTo(sizeof(DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD)));
        }

        /// <summary>Validates that the <see cref="DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DEVICEDUMP_STORAGESTACK_PUBLIC_STATE_RECORD), Is.EqualTo(60));
        }
    }
}
