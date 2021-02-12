// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="RID_DEVICE_INFO_MOUSE" /> struct.</summary>
    public static unsafe class RID_DEVICE_INFO_MOUSETests
    {
        /// <summary>Validates that the <see cref="RID_DEVICE_INFO_MOUSE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<RID_DEVICE_INFO_MOUSE>(), Is.EqualTo(sizeof(RID_DEVICE_INFO_MOUSE)));
        }

        /// <summary>Validates that the <see cref="RID_DEVICE_INFO_MOUSE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(RID_DEVICE_INFO_MOUSE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="RID_DEVICE_INFO_MOUSE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(RID_DEVICE_INFO_MOUSE), Is.EqualTo(16));
        }
    }
}
