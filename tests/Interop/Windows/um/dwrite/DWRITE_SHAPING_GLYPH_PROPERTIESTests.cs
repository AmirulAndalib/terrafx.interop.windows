// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DWRITE_SHAPING_GLYPH_PROPERTIES" /> struct.</summary>
    public static unsafe class DWRITE_SHAPING_GLYPH_PROPERTIESTests
    {
        /// <summary>Validates that the <see cref="DWRITE_SHAPING_GLYPH_PROPERTIES" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DWRITE_SHAPING_GLYPH_PROPERTIES>(), Is.EqualTo(sizeof(DWRITE_SHAPING_GLYPH_PROPERTIES)));
        }

        /// <summary>Validates that the <see cref="DWRITE_SHAPING_GLYPH_PROPERTIES" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DWRITE_SHAPING_GLYPH_PROPERTIES).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DWRITE_SHAPING_GLYPH_PROPERTIES" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DWRITE_SHAPING_GLYPH_PROPERTIES), Is.EqualTo(2));
        }
    }
}
