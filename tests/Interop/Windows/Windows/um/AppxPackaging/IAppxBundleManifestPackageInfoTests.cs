// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAppxBundleManifestPackageInfo" /> struct.</summary>
    [SupportedOSPlatform("windows8.1")]
    public static unsafe partial class IAppxBundleManifestPackageInfoTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppxBundleManifestPackageInfo" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAppxBundleManifestPackageInfo).GUID, Is.EqualTo(IID_IAppxBundleManifestPackageInfo));
        }

        /// <summary>Validates that the <see cref="IAppxBundleManifestPackageInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAppxBundleManifestPackageInfo>(), Is.EqualTo(sizeof(IAppxBundleManifestPackageInfo)));
        }

        /// <summary>Validates that the <see cref="IAppxBundleManifestPackageInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAppxBundleManifestPackageInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAppxBundleManifestPackageInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAppxBundleManifestPackageInfo), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAppxBundleManifestPackageInfo), Is.EqualTo(4));
            }
        }
    }
}
