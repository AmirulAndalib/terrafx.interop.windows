// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HTML_PAINT_DRAW_INFO" /> struct.</summary>
    public static unsafe partial class HTML_PAINT_DRAW_INFOTests
    {
        /// <summary>Validates that the <see cref="HTML_PAINT_DRAW_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HTML_PAINT_DRAW_INFO>(), Is.EqualTo(sizeof(HTML_PAINT_DRAW_INFO)));
        }

        /// <summary>Validates that the <see cref="HTML_PAINT_DRAW_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HTML_PAINT_DRAW_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HTML_PAINT_DRAW_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(HTML_PAINT_DRAW_INFO), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(HTML_PAINT_DRAW_INFO), Is.EqualTo(44));
            }
        }
    }
}
