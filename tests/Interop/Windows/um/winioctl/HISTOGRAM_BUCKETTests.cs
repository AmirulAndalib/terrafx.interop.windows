// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HISTOGRAM_BUCKET" /> struct.</summary>
    public static unsafe class HISTOGRAM_BUCKETTests
    {
        /// <summary>Validates that the <see cref="HISTOGRAM_BUCKET" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HISTOGRAM_BUCKET>(), Is.EqualTo(sizeof(HISTOGRAM_BUCKET)));
        }

        /// <summary>Validates that the <see cref="HISTOGRAM_BUCKET" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HISTOGRAM_BUCKET).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HISTOGRAM_BUCKET" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(HISTOGRAM_BUCKET), Is.EqualTo(8));
        }
    }
}
