// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="OUTLINETEXTMETRICA" /> struct.</summary>
    public static unsafe class OUTLINETEXTMETRICATests
    {
        /// <summary>Validates that the <see cref="OUTLINETEXTMETRICA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<OUTLINETEXTMETRICA>(), Is.EqualTo(sizeof(OUTLINETEXTMETRICA)));
        }

        /// <summary>Validates that the <see cref="OUTLINETEXTMETRICA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(OUTLINETEXTMETRICA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="OUTLINETEXTMETRICA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(OUTLINETEXTMETRICA), Is.EqualTo(232));
            }
            else
            {
                Assert.That(sizeof(OUTLINETEXTMETRICA), Is.EqualTo(212));
            }
        }
    }
}
