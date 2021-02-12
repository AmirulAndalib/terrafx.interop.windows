// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="EMRCREATECOLORSPACEW" /> struct.</summary>
    public static unsafe class EMRCREATECOLORSPACEWTests
    {
        /// <summary>Validates that the <see cref="EMRCREATECOLORSPACEW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<EMRCREATECOLORSPACEW>(), Is.EqualTo(sizeof(EMRCREATECOLORSPACEW)));
        }

        /// <summary>Validates that the <see cref="EMRCREATECOLORSPACEW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(EMRCREATECOLORSPACEW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="EMRCREATECOLORSPACEW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(EMRCREATECOLORSPACEW), Is.EqualTo(612));
        }
    }
}
