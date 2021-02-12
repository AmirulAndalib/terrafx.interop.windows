// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IPropertyPageSite" /> struct.</summary>
    public static unsafe class IPropertyPageSiteTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IPropertyPageSite" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IPropertyPageSite).GUID, Is.EqualTo(IID_IPropertyPageSite));
        }

        /// <summary>Validates that the <see cref="IPropertyPageSite" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IPropertyPageSite>(), Is.EqualTo(sizeof(IPropertyPageSite)));
        }

        /// <summary>Validates that the <see cref="IPropertyPageSite" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IPropertyPageSite).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IPropertyPageSite" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IPropertyPageSite), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IPropertyPageSite), Is.EqualTo(4));
            }
        }
    }
}
