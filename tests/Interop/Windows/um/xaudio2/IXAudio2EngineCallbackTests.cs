// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IXAudio2EngineCallback" /> struct.</summary>
    public static unsafe class IXAudio2EngineCallbackTests
    {
        /// <summary>Validates that the <see cref="IXAudio2EngineCallback" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IXAudio2EngineCallback>(), Is.EqualTo(sizeof(IXAudio2EngineCallback)));
        }

        /// <summary>Validates that the <see cref="IXAudio2EngineCallback" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IXAudio2EngineCallback).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IXAudio2EngineCallback" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IXAudio2EngineCallback), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IXAudio2EngineCallback), Is.EqualTo(4));
            }
        }
    }
}
