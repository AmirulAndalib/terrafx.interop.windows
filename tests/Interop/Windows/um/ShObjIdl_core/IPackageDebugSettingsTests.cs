// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IPackageDebugSettings" /> struct.</summary>
    public static unsafe partial class IPackageDebugSettingsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IPackageDebugSettings" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IPackageDebugSettings).GUID, Is.EqualTo(IID_IPackageDebugSettings));
        }

        /// <summary>Validates that the <see cref="IPackageDebugSettings" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IPackageDebugSettings>(), Is.EqualTo(sizeof(IPackageDebugSettings)));
        }

        /// <summary>Validates that the <see cref="IPackageDebugSettings" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IPackageDebugSettings).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IPackageDebugSettings" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IPackageDebugSettings), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IPackageDebugSettings), Is.EqualTo(4));
            }
        }
    }
}
