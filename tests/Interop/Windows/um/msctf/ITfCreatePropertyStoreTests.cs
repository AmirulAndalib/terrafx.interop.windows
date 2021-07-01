// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ITfCreatePropertyStore" /> struct.</summary>
    public static unsafe class ITfCreatePropertyStoreTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ITfCreatePropertyStore" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ITfCreatePropertyStore).GUID, Is.EqualTo(IID_ITfCreatePropertyStore));
        }

        /// <summary>Validates that the <see cref="ITfCreatePropertyStore" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ITfCreatePropertyStore>(), Is.EqualTo(sizeof(ITfCreatePropertyStore)));
        }

        /// <summary>Validates that the <see cref="ITfCreatePropertyStore" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ITfCreatePropertyStore).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ITfCreatePropertyStore" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ITfCreatePropertyStore), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ITfCreatePropertyStore), Is.EqualTo(4));
            }
        }
    }
}
