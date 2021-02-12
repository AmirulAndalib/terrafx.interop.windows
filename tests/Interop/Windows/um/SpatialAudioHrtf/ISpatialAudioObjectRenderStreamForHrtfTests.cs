// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISpatialAudioObjectRenderStreamForHrtf" /> struct.</summary>
    public static unsafe class ISpatialAudioObjectRenderStreamForHrtfTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISpatialAudioObjectRenderStreamForHrtf" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISpatialAudioObjectRenderStreamForHrtf).GUID, Is.EqualTo(IID_ISpatialAudioObjectRenderStreamForHrtf));
        }

        /// <summary>Validates that the <see cref="ISpatialAudioObjectRenderStreamForHrtf" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISpatialAudioObjectRenderStreamForHrtf>(), Is.EqualTo(sizeof(ISpatialAudioObjectRenderStreamForHrtf)));
        }

        /// <summary>Validates that the <see cref="ISpatialAudioObjectRenderStreamForHrtf" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISpatialAudioObjectRenderStreamForHrtf).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISpatialAudioObjectRenderStreamForHrtf" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISpatialAudioObjectRenderStreamForHrtf), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISpatialAudioObjectRenderStreamForHrtf), Is.EqualTo(4));
            }
        }
    }
}
