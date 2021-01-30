// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MsftDiscFormat2TrackAtOnce" /> struct.</summary>
    public static unsafe class MsftDiscFormat2TrackAtOnceTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="MsftDiscFormat2TrackAtOnce" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(MsftDiscFormat2TrackAtOnce).GUID, Is.EqualTo(CLSID_MsftDiscFormat2TrackAtOnce));
        }

        /// <summary>Validates that the <see cref="MsftDiscFormat2TrackAtOnce" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MsftDiscFormat2TrackAtOnce>(), Is.EqualTo(sizeof(MsftDiscFormat2TrackAtOnce)));
        }

        /// <summary>Validates that the <see cref="MsftDiscFormat2TrackAtOnce" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MsftDiscFormat2TrackAtOnce).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MsftDiscFormat2TrackAtOnce" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MsftDiscFormat2TrackAtOnce), Is.EqualTo(1));
        }
    }
}
