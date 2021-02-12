// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MIXERLINECONTROLSA" /> struct.</summary>
    public static unsafe class MIXERLINECONTROLSATests
    {
        /// <summary>Validates that the <see cref="MIXERLINECONTROLSA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MIXERLINECONTROLSA>(), Is.EqualTo(sizeof(MIXERLINECONTROLSA)));
        }

        /// <summary>Validates that the <see cref="MIXERLINECONTROLSA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MIXERLINECONTROLSA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MIXERLINECONTROLSA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(MIXERLINECONTROLSA), Is.EqualTo(28));
            }
            else
            {
                Assert.That(sizeof(MIXERLINECONTROLSA), Is.EqualTo(24));
            }
        }
    }
}
