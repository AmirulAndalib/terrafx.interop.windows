// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SpatialAudioObjectRenderStreamForMetadataActivationParams" /> struct.</summary>
    public static unsafe class SpatialAudioObjectRenderStreamForMetadataActivationParamsTests
    {
        /// <summary>Validates that the <see cref="SpatialAudioObjectRenderStreamForMetadataActivationParams" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SpatialAudioObjectRenderStreamForMetadataActivationParams>(), Is.EqualTo(sizeof(SpatialAudioObjectRenderStreamForMetadataActivationParams)));
        }

        /// <summary>Validates that the <see cref="SpatialAudioObjectRenderStreamForMetadataActivationParams" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SpatialAudioObjectRenderStreamForMetadataActivationParams).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SpatialAudioObjectRenderStreamForMetadataActivationParams" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SpatialAudioObjectRenderStreamForMetadataActivationParams), Is.EqualTo(66));
            }
            else
            {
                Assert.That(sizeof(SpatialAudioObjectRenderStreamForMetadataActivationParams), Is.EqualTo(50));
            }
        }
    }
}
