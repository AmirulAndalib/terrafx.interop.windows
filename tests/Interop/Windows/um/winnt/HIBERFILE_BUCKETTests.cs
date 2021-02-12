// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HIBERFILE_BUCKET" /> struct.</summary>
    public static unsafe class HIBERFILE_BUCKETTests
    {
        /// <summary>Validates that the <see cref="HIBERFILE_BUCKET" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HIBERFILE_BUCKET>(), Is.EqualTo(sizeof(HIBERFILE_BUCKET)));
        }

        /// <summary>Validates that the <see cref="HIBERFILE_BUCKET" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HIBERFILE_BUCKET).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HIBERFILE_BUCKET" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(HIBERFILE_BUCKET), Is.EqualTo(24));
        }
    }
}
