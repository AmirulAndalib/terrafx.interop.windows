// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="AudioVolumeMeter" /> struct.</summary>
    public static unsafe class AudioVolumeMeterTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="AudioVolumeMeter" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(AudioVolumeMeter).GUID, Is.EqualTo(CLSID_AudioVolumeMeter));
        }

        /// <summary>Validates that the <see cref="AudioVolumeMeter" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<AudioVolumeMeter>(), Is.EqualTo(sizeof(AudioVolumeMeter)));
        }

        /// <summary>Validates that the <see cref="AudioVolumeMeter" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(AudioVolumeMeter).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="AudioVolumeMeter" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(AudioVolumeMeter), Is.EqualTo(1));
        }
    }
}
