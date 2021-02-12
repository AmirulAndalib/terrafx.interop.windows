// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT" /> struct.</summary>
    public static unsafe class D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINTTests
    {
        /// <summary>Validates that the <see cref="D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT>(), Is.EqualTo(sizeof(D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT)));
        }

        /// <summary>Validates that the <see cref="D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3D11_VIDEO_PROCESSOR_STREAM_BEHAVIOR_HINT), Is.EqualTo(16));
        }
    }
}
