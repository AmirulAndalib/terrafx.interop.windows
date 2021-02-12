// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="GET_CHANGER_PARAMETERS" /> struct.</summary>
    public static unsafe class GET_CHANGER_PARAMETERSTests
    {
        /// <summary>Validates that the <see cref="GET_CHANGER_PARAMETERS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<GET_CHANGER_PARAMETERS>(), Is.EqualTo(sizeof(GET_CHANGER_PARAMETERS)));
        }

        /// <summary>Validates that the <see cref="GET_CHANGER_PARAMETERS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(GET_CHANGER_PARAMETERS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="GET_CHANGER_PARAMETERS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(GET_CHANGER_PARAMETERS), Is.EqualTo(60));
        }
    }
}
