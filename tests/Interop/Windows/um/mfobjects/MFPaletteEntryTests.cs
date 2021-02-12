// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MFPaletteEntry" /> struct.</summary>
    public static unsafe class MFPaletteEntryTests
    {
        /// <summary>Validates that the <see cref="MFPaletteEntry" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MFPaletteEntry>(), Is.EqualTo(sizeof(MFPaletteEntry)));
        }

        /// <summary>Validates that the <see cref="MFPaletteEntry" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutExplicitTest()
        {
            Assert.That(typeof(MFPaletteEntry).IsExplicitLayout, Is.True);
        }

        /// <summary>Validates that the <see cref="MFPaletteEntry" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MFPaletteEntry), Is.EqualTo(4));
        }
    }
}
