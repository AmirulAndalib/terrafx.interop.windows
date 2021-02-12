// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MANIPULATION_VELOCITY" /> struct.</summary>
    public static unsafe class MANIPULATION_VELOCITYTests
    {
        /// <summary>Validates that the <see cref="MANIPULATION_VELOCITY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MANIPULATION_VELOCITY>(), Is.EqualTo(sizeof(MANIPULATION_VELOCITY)));
        }

        /// <summary>Validates that the <see cref="MANIPULATION_VELOCITY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MANIPULATION_VELOCITY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MANIPULATION_VELOCITY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MANIPULATION_VELOCITY), Is.EqualTo(16));
        }
    }
}
