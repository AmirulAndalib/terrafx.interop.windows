// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DWRITE_CARET_METRICS" /> struct.</summary>
    public static unsafe class DWRITE_CARET_METRICSTests
    {
        /// <summary>Validates that the <see cref="DWRITE_CARET_METRICS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DWRITE_CARET_METRICS>(), Is.EqualTo(sizeof(DWRITE_CARET_METRICS)));
        }

        /// <summary>Validates that the <see cref="DWRITE_CARET_METRICS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DWRITE_CARET_METRICS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DWRITE_CARET_METRICS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DWRITE_CARET_METRICS), Is.EqualTo(6));
        }
    }
}
