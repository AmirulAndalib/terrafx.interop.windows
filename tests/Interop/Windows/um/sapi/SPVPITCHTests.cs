// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SPVPITCH" /> struct.</summary>
    public static unsafe class SPVPITCHTests
    {
        /// <summary>Validates that the <see cref="SPVPITCH" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SPVPITCH>(), Is.EqualTo(sizeof(SPVPITCH)));
        }

        /// <summary>Validates that the <see cref="SPVPITCH" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SPVPITCH).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SPVPITCH" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SPVPITCH), Is.EqualTo(8));
        }
    }
}
