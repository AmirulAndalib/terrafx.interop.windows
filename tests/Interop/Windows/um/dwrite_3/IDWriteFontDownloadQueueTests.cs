// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDWriteFontDownloadQueue" /> struct.</summary>
    public static unsafe class IDWriteFontDownloadQueueTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDWriteFontDownloadQueue" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDWriteFontDownloadQueue).GUID, Is.EqualTo(IID_IDWriteFontDownloadQueue));
        }

        /// <summary>Validates that the <see cref="IDWriteFontDownloadQueue" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDWriteFontDownloadQueue>(), Is.EqualTo(sizeof(IDWriteFontDownloadQueue)));
        }

        /// <summary>Validates that the <see cref="IDWriteFontDownloadQueue" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDWriteFontDownloadQueue).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDWriteFontDownloadQueue" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDWriteFontDownloadQueue), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDWriteFontDownloadQueue), Is.EqualTo(4));
            }
        }
    }
}
