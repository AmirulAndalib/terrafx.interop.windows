// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMAGE_AUX_SYMBOL_EX" /> struct.</summary>
    public static unsafe class IMAGE_AUX_SYMBOL_EXTests
    {
        /// <summary>Validates that the <see cref="IMAGE_AUX_SYMBOL_EX" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMAGE_AUX_SYMBOL_EX>(), Is.EqualTo(sizeof(IMAGE_AUX_SYMBOL_EX)));
        }

        /// <summary>Validates that the <see cref="IMAGE_AUX_SYMBOL_EX" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(IMAGE_AUX_SYMBOL_EX).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="IMAGE_AUX_SYMBOL_EX" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(IMAGE_AUX_SYMBOL_EX), Is.EqualTo(20));
        }
    }
}
