// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IFolderFilter" /> struct.</summary>
    public static unsafe class IFolderFilterTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IFolderFilter" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IFolderFilter).GUID, Is.EqualTo(IID_IFolderFilter));
        }

        /// <summary>Validates that the <see cref="IFolderFilter" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IFolderFilter>(), Is.EqualTo(sizeof(IFolderFilter)));
        }

        /// <summary>Validates that the <see cref="IFolderFilter" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IFolderFilter).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IFolderFilter" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IFolderFilter), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IFolderFilter), Is.EqualTo(4));
            }
        }
    }
}
