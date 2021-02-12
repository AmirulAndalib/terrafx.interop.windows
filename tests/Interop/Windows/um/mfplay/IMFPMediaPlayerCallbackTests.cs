// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMFPMediaPlayerCallback" /> struct.</summary>
    public static unsafe class IMFPMediaPlayerCallbackTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFPMediaPlayerCallback" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMFPMediaPlayerCallback).GUID, Is.EqualTo(IID_IMFPMediaPlayerCallback));
        }

        /// <summary>Validates that the <see cref="IMFPMediaPlayerCallback" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMFPMediaPlayerCallback>(), Is.EqualTo(sizeof(IMFPMediaPlayerCallback)));
        }

        /// <summary>Validates that the <see cref="IMFPMediaPlayerCallback" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMFPMediaPlayerCallback).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMFPMediaPlayerCallback" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMFPMediaPlayerCallback), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMFPMediaPlayerCallback), Is.EqualTo(4));
            }
        }
    }
}
