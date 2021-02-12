// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DISPLAYCONFIG_RATIONAL" /> struct.</summary>
    public static unsafe class DISPLAYCONFIG_RATIONALTests
    {
        /// <summary>Validates that the <see cref="DISPLAYCONFIG_RATIONAL" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DISPLAYCONFIG_RATIONAL>(), Is.EqualTo(sizeof(DISPLAYCONFIG_RATIONAL)));
        }

        /// <summary>Validates that the <see cref="DISPLAYCONFIG_RATIONAL" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DISPLAYCONFIG_RATIONAL).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DISPLAYCONFIG_RATIONAL" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DISPLAYCONFIG_RATIONAL), Is.EqualTo(8));
        }
    }
}
