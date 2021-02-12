// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CONSOLE_FONT_INFOEX" /> struct.</summary>
    public static unsafe class CONSOLE_FONT_INFOEXTests
    {
        /// <summary>Validates that the <see cref="CONSOLE_FONT_INFOEX" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CONSOLE_FONT_INFOEX>(), Is.EqualTo(sizeof(CONSOLE_FONT_INFOEX)));
        }

        /// <summary>Validates that the <see cref="CONSOLE_FONT_INFOEX" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CONSOLE_FONT_INFOEX).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CONSOLE_FONT_INFOEX" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CONSOLE_FONT_INFOEX), Is.EqualTo(84));
        }
    }
}
