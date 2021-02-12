// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmp2dlna.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MFMPEG2DLNASINKSTATS" /> struct.</summary>
    public static unsafe class MFMPEG2DLNASINKSTATSTests
    {
        /// <summary>Validates that the <see cref="MFMPEG2DLNASINKSTATS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MFMPEG2DLNASINKSTATS>(), Is.EqualTo(sizeof(MFMPEG2DLNASINKSTATS)));
        }

        /// <summary>Validates that the <see cref="MFMPEG2DLNASINKSTATS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MFMPEG2DLNASINKSTATS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MFMPEG2DLNASINKSTATS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MFMPEG2DLNASINKSTATS), Is.EqualTo(88));
        }
    }
}
