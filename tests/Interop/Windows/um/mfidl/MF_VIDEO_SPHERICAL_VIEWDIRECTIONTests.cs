// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MF_VIDEO_SPHERICAL_VIEWDIRECTION" /> struct.</summary>
    public static unsafe class MF_VIDEO_SPHERICAL_VIEWDIRECTIONTests
    {
        /// <summary>Validates that the <see cref="MF_VIDEO_SPHERICAL_VIEWDIRECTION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MF_VIDEO_SPHERICAL_VIEWDIRECTION>(), Is.EqualTo(sizeof(MF_VIDEO_SPHERICAL_VIEWDIRECTION)));
        }

        /// <summary>Validates that the <see cref="MF_VIDEO_SPHERICAL_VIEWDIRECTION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MF_VIDEO_SPHERICAL_VIEWDIRECTION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MF_VIDEO_SPHERICAL_VIEWDIRECTION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MF_VIDEO_SPHERICAL_VIEWDIRECTION), Is.EqualTo(12));
        }
    }
}
