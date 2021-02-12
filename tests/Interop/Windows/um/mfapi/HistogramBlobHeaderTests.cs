// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HistogramBlobHeader" /> struct.</summary>
    public static unsafe class HistogramBlobHeaderTests
    {
        /// <summary>Validates that the <see cref="HistogramBlobHeader" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HistogramBlobHeader>(), Is.EqualTo(sizeof(HistogramBlobHeader)));
        }

        /// <summary>Validates that the <see cref="HistogramBlobHeader" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HistogramBlobHeader).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HistogramBlobHeader" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(HistogramBlobHeader), Is.EqualTo(8));
        }
    }
}
