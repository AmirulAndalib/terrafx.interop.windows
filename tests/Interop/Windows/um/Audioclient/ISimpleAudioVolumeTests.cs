// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISimpleAudioVolume" /> struct.</summary>
    public static unsafe class ISimpleAudioVolumeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISimpleAudioVolume" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISimpleAudioVolume).GUID, Is.EqualTo(IID_ISimpleAudioVolume));
        }

        /// <summary>Validates that the <see cref="ISimpleAudioVolume" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISimpleAudioVolume>(), Is.EqualTo(sizeof(ISimpleAudioVolume)));
        }

        /// <summary>Validates that the <see cref="ISimpleAudioVolume" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISimpleAudioVolume).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISimpleAudioVolume" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISimpleAudioVolume), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISimpleAudioVolume), Is.EqualTo(4));
            }
        }
    }
}
