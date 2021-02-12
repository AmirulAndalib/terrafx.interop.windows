// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMediaSample" /> struct.</summary>
    public static unsafe class IMediaSampleTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMediaSample" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMediaSample).GUID, Is.EqualTo(IID_IMediaSample));
        }

        /// <summary>Validates that the <see cref="IMediaSample" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMediaSample>(), Is.EqualTo(sizeof(IMediaSample)));
        }

        /// <summary>Validates that the <see cref="IMediaSample" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMediaSample).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMediaSample" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMediaSample), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMediaSample), Is.EqualTo(4));
            }
        }
    }
}
