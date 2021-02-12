// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WAVEHDR" /> struct.</summary>
    public static unsafe class WAVEHDRTests
    {
        /// <summary>Validates that the <see cref="WAVEHDR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WAVEHDR>(), Is.EqualTo(sizeof(WAVEHDR)));
        }

        /// <summary>Validates that the <see cref="WAVEHDR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WAVEHDR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WAVEHDR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(WAVEHDR), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(WAVEHDR), Is.EqualTo(32));
            }
        }
    }
}
