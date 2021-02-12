// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PELARRAY" /> struct.</summary>
    public static unsafe class PELARRAYTests
    {
        /// <summary>Validates that the <see cref="PELARRAY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PELARRAY>(), Is.EqualTo(sizeof(PELARRAY)));
        }

        /// <summary>Validates that the <see cref="PELARRAY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PELARRAY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PELARRAY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PELARRAY), Is.EqualTo(20));
        }
    }
}
