// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MIXERLINEA" /> struct.</summary>
    public static unsafe class MIXERLINEATests
    {
        /// <summary>Validates that the <see cref="MIXERLINEA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MIXERLINEA>(), Is.EqualTo(sizeof(MIXERLINEA)));
        }

        /// <summary>Validates that the <see cref="MIXERLINEA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MIXERLINEA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MIXERLINEA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(MIXERLINEA), Is.EqualTo(172));
            }
            else
            {
                Assert.That(sizeof(MIXERLINEA), Is.EqualTo(168));
            }
        }
    }
}
