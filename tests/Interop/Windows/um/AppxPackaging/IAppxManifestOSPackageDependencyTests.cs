// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAppxManifestOSPackageDependency" /> struct.</summary>
    public static unsafe partial class IAppxManifestOSPackageDependencyTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppxManifestOSPackageDependency" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAppxManifestOSPackageDependency).GUID, Is.EqualTo(IID_IAppxManifestOSPackageDependency));
        }

        /// <summary>Validates that the <see cref="IAppxManifestOSPackageDependency" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAppxManifestOSPackageDependency>(), Is.EqualTo(sizeof(IAppxManifestOSPackageDependency)));
        }

        /// <summary>Validates that the <see cref="IAppxManifestOSPackageDependency" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAppxManifestOSPackageDependency).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAppxManifestOSPackageDependency" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAppxManifestOSPackageDependency), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAppxManifestOSPackageDependency), Is.EqualTo(4));
            }
        }
    }
}
