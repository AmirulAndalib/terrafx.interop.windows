// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IShellFolderView" /> struct.</summary>
    public static unsafe partial class IShellFolderViewTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IShellFolderView" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IShellFolderView).GUID, Is.EqualTo(IID_IShellFolderView));
        }

        /// <summary>Validates that the <see cref="IShellFolderView" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IShellFolderView>(), Is.EqualTo(sizeof(IShellFolderView)));
        }

        /// <summary>Validates that the <see cref="IShellFolderView" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IShellFolderView).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IShellFolderView" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IShellFolderView), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IShellFolderView), Is.EqualTo(4));
            }
        }
    }
}
