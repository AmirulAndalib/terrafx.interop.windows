// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWICStreamProvider" /> struct.</summary>
    public static unsafe class IWICStreamProviderTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWICStreamProvider" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWICStreamProvider).GUID, Is.EqualTo(IID_IWICStreamProvider));
        }

        /// <summary>Validates that the <see cref="IWICStreamProvider" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IWICStreamProvider>(), Is.EqualTo(sizeof(IWICStreamProvider)));
        }

        /// <summary>Validates that the <see cref="IWICStreamProvider" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWICStreamProvider).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IWICStreamProvider" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IWICStreamProvider), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IWICStreamProvider), Is.EqualTo(4));
            }
        }
    }
}
