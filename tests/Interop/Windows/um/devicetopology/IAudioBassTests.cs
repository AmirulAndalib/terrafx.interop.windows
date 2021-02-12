// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAudioBass" /> struct.</summary>
    public static unsafe class IAudioBassTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAudioBass" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAudioBass).GUID, Is.EqualTo(IID_IAudioBass));
        }

        /// <summary>Validates that the <see cref="IAudioBass" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAudioBass>(), Is.EqualTo(sizeof(IAudioBass)));
        }

        /// <summary>Validates that the <see cref="IAudioBass" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAudioBass).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAudioBass" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAudioBass), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAudioBass), Is.EqualTo(4));
            }
        }
    }
}
