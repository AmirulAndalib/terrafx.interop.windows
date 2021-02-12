// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDWriteFactory7" /> struct.</summary>
    public static unsafe class IDWriteFactory7Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteFactory7" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDWriteFactory7).GUID, Is.EqualTo(IID_IDWriteFactory7));
        }

        /// <summary>Validates that the <see cref="IDWriteFactory7" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDWriteFactory7>(), Is.EqualTo(sizeof(IDWriteFactory7)));
        }

        /// <summary>Validates that the <see cref="IDWriteFactory7" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDWriteFactory7).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDWriteFactory7" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDWriteFactory7), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDWriteFactory7), Is.EqualTo(4));
            }
        }
    }
}
