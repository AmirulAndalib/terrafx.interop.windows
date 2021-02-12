// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SpAudioFormat" /> struct.</summary>
    public static unsafe class SpAudioFormatTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="SpAudioFormat" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(SpAudioFormat).GUID, Is.EqualTo(CLSID_SpAudioFormat));
        }

        /// <summary>Validates that the <see cref="SpAudioFormat" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SpAudioFormat>(), Is.EqualTo(sizeof(SpAudioFormat)));
        }

        /// <summary>Validates that the <see cref="SpAudioFormat" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SpAudioFormat).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SpAudioFormat" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SpAudioFormat), Is.EqualTo(1));
        }
    }
}
