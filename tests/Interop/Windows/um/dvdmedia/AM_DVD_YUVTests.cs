// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="AM_DVD_YUV" /> struct.</summary>
    public static unsafe class AM_DVD_YUVTests
    {
        /// <summary>Validates that the <see cref="AM_DVD_YUV" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<AM_DVD_YUV>(), Is.EqualTo(sizeof(AM_DVD_YUV)));
        }

        /// <summary>Validates that the <see cref="AM_DVD_YUV" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(AM_DVD_YUV).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="AM_DVD_YUV" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(AM_DVD_YUV), Is.EqualTo(4));
        }
    }
}
