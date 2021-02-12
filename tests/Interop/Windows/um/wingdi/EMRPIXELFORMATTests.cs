// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="EMRPIXELFORMAT" /> struct.</summary>
    public static unsafe class EMRPIXELFORMATTests
    {
        /// <summary>Validates that the <see cref="EMRPIXELFORMAT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<EMRPIXELFORMAT>(), Is.EqualTo(sizeof(EMRPIXELFORMAT)));
        }

        /// <summary>Validates that the <see cref="EMRPIXELFORMAT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(EMRPIXELFORMAT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="EMRPIXELFORMAT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(EMRPIXELFORMAT), Is.EqualTo(48));
        }
    }
}
