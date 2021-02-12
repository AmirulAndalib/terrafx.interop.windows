// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ENUMLOGFONTW" /> struct.</summary>
    public static unsafe class ENUMLOGFONTWTests
    {
        /// <summary>Validates that the <see cref="ENUMLOGFONTW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ENUMLOGFONTW>(), Is.EqualTo(sizeof(ENUMLOGFONTW)));
        }

        /// <summary>Validates that the <see cref="ENUMLOGFONTW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ENUMLOGFONTW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ENUMLOGFONTW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(ENUMLOGFONTW), Is.EqualTo(284));
        }
    }
}
