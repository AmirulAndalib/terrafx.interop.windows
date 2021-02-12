// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="XAUDIO2_VOICE_DETAILS" /> struct.</summary>
    public static unsafe class XAUDIO2_VOICE_DETAILSTests
    {
        /// <summary>Validates that the <see cref="XAUDIO2_VOICE_DETAILS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<XAUDIO2_VOICE_DETAILS>(), Is.EqualTo(sizeof(XAUDIO2_VOICE_DETAILS)));
        }

        /// <summary>Validates that the <see cref="XAUDIO2_VOICE_DETAILS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(XAUDIO2_VOICE_DETAILS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="XAUDIO2_VOICE_DETAILS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(XAUDIO2_VOICE_DETAILS), Is.EqualTo(16));
        }
    }
}
