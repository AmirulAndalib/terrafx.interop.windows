// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="AM_DVDCOPY_SET_COPY_STATE" /> struct.</summary>
    public static unsafe class AM_DVDCOPY_SET_COPY_STATETests
    {
        /// <summary>Validates that the <see cref="AM_DVDCOPY_SET_COPY_STATE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<AM_DVDCOPY_SET_COPY_STATE>(), Is.EqualTo(sizeof(AM_DVDCOPY_SET_COPY_STATE)));
        }

        /// <summary>Validates that the <see cref="AM_DVDCOPY_SET_COPY_STATE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(AM_DVDCOPY_SET_COPY_STATE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="AM_DVDCOPY_SET_COPY_STATE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(AM_DVDCOPY_SET_COPY_STATE), Is.EqualTo(4));
        }
    }
}
