// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ADPCMWAVEFORMAT" /> struct.</summary>
    public static unsafe class ADPCMWAVEFORMATTests
    {
        /// <summary>Validates that the <see cref="ADPCMWAVEFORMAT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ADPCMWAVEFORMAT>(), Is.EqualTo(sizeof(ADPCMWAVEFORMAT)));
        }

        /// <summary>Validates that the <see cref="ADPCMWAVEFORMAT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ADPCMWAVEFORMAT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ADPCMWAVEFORMAT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(ADPCMWAVEFORMAT), Is.EqualTo(26));
        }
    }
}
