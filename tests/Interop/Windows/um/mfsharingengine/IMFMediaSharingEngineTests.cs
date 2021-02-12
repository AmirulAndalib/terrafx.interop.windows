// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMFMediaSharingEngine" /> struct.</summary>
    public static unsafe class IMFMediaSharingEngineTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFMediaSharingEngine" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMFMediaSharingEngine).GUID, Is.EqualTo(IID_IMFMediaSharingEngine));
        }

        /// <summary>Validates that the <see cref="IMFMediaSharingEngine" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMFMediaSharingEngine>(), Is.EqualTo(sizeof(IMFMediaSharingEngine)));
        }

        /// <summary>Validates that the <see cref="IMFMediaSharingEngine" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMFMediaSharingEngine).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMFMediaSharingEngine" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMFMediaSharingEngine), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMFMediaSharingEngine), Is.EqualTo(4));
            }
        }
    }
}
