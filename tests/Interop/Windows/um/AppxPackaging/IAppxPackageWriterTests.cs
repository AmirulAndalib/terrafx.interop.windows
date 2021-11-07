// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAppxPackageWriter" /> struct.</summary>
    [SupportedOSPlatform("windows8.0")]
    public static unsafe partial class IAppxPackageWriterTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppxPackageWriter" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAppxPackageWriter).GUID, Is.EqualTo(IID_IAppxPackageWriter));
        }

        /// <summary>Validates that the <see cref="IAppxPackageWriter" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAppxPackageWriter>(), Is.EqualTo(sizeof(IAppxPackageWriter)));
        }

        /// <summary>Validates that the <see cref="IAppxPackageWriter" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAppxPackageWriter).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAppxPackageWriter" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAppxPackageWriter), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAppxPackageWriter), Is.EqualTo(4));
            }
        }
    }
}
