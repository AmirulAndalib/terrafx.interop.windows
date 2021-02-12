// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMFMediaSourceEx" /> struct.</summary>
    public static unsafe class IMFMediaSourceExTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFMediaSourceEx" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMFMediaSourceEx).GUID, Is.EqualTo(IID_IMFMediaSourceEx));
        }

        /// <summary>Validates that the <see cref="IMFMediaSourceEx" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMFMediaSourceEx>(), Is.EqualTo(sizeof(IMFMediaSourceEx)));
        }

        /// <summary>Validates that the <see cref="IMFMediaSourceEx" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMFMediaSourceEx).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMFMediaSourceEx" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMFMediaSourceEx), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMFMediaSourceEx), Is.EqualTo(4));
            }
        }
    }
}
