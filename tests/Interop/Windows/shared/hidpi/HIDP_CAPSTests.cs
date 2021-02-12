// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HIDP_CAPS" /> struct.</summary>
    public static unsafe class HIDP_CAPSTests
    {
        /// <summary>Validates that the <see cref="HIDP_CAPS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HIDP_CAPS>(), Is.EqualTo(sizeof(HIDP_CAPS)));
        }

        /// <summary>Validates that the <see cref="HIDP_CAPS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HIDP_CAPS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HIDP_CAPS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(HIDP_CAPS), Is.EqualTo(64));
        }
    }
}
