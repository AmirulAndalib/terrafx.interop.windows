// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="MsftFileSystemImage" /> struct.</summary>
    public static unsafe partial class MsftFileSystemImageTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="MsftFileSystemImage" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(MsftFileSystemImage).GUID, Is.EqualTo(CLSID_MsftFileSystemImage));
        }

        /// <summary>Validates that the <see cref="MsftFileSystemImage" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MsftFileSystemImage>(), Is.EqualTo(sizeof(MsftFileSystemImage)));
        }

        /// <summary>Validates that the <see cref="MsftFileSystemImage" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MsftFileSystemImage).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MsftFileSystemImage" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MsftFileSystemImage), Is.EqualTo(1));
        }
    }
}
