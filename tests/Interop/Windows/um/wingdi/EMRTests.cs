// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="EMR" /> struct.</summary>
    public static unsafe class EMRTests
    {
        /// <summary>Validates that the <see cref="EMR" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<EMR>(), Is.EqualTo(sizeof(EMR)));
        }

        /// <summary>Validates that the <see cref="EMR" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(EMR).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="EMR" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(EMR), Is.EqualTo(8));
        }
    }
}
