// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SIP_CAP_SET_V3" /> struct.</summary>
    public static unsafe class SIP_CAP_SET_V3Tests
    {
        /// <summary>Validates that the <see cref="SIP_CAP_SET_V3" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SIP_CAP_SET_V3>(), Is.EqualTo(sizeof(SIP_CAP_SET_V3)));
        }

        /// <summary>Validates that the <see cref="SIP_CAP_SET_V3" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SIP_CAP_SET_V3).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SIP_CAP_SET_V3" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SIP_CAP_SET_V3), Is.EqualTo(16));
        }
    }
}
