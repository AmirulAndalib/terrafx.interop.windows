// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DEVICE_DSM_OFFLOAD_WRITE_PARAMETERS" /> struct.</summary>
    public static unsafe class DEVICE_DSM_OFFLOAD_WRITE_PARAMETERSTests
    {
        /// <summary>Validates that the <see cref="DEVICE_DSM_OFFLOAD_WRITE_PARAMETERS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DEVICE_DSM_OFFLOAD_WRITE_PARAMETERS>(), Is.EqualTo(sizeof(DEVICE_DSM_OFFLOAD_WRITE_PARAMETERS)));
        }

        /// <summary>Validates that the <see cref="DEVICE_DSM_OFFLOAD_WRITE_PARAMETERS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DEVICE_DSM_OFFLOAD_WRITE_PARAMETERS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DEVICE_DSM_OFFLOAD_WRITE_PARAMETERS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DEVICE_DSM_OFFLOAD_WRITE_PARAMETERS), Is.EqualTo(528));
        }
    }
}
