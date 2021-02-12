// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="FaceCharacterization" /> struct.</summary>
    public static unsafe class FaceCharacterizationTests
    {
        /// <summary>Validates that the <see cref="FaceCharacterization" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<FaceCharacterization>(), Is.EqualTo(sizeof(FaceCharacterization)));
        }

        /// <summary>Validates that the <see cref="FaceCharacterization" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(FaceCharacterization).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="FaceCharacterization" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(FaceCharacterization), Is.EqualTo(16));
        }
    }
}
