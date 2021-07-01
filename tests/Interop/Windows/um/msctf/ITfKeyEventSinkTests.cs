// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ITfKeyEventSink" /> struct.</summary>
    public static unsafe class ITfKeyEventSinkTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ITfKeyEventSink" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ITfKeyEventSink).GUID, Is.EqualTo(IID_ITfKeyEventSink));
        }

        /// <summary>Validates that the <see cref="ITfKeyEventSink" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ITfKeyEventSink>(), Is.EqualTo(sizeof(ITfKeyEventSink)));
        }

        /// <summary>Validates that the <see cref="ITfKeyEventSink" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ITfKeyEventSink).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ITfKeyEventSink" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ITfKeyEventSink), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ITfKeyEventSink), Is.EqualTo(4));
            }
        }
    }
}
