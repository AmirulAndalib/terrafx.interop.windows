// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDCompositionGaussianBlurEffect" /> struct.</summary>
    public static unsafe class IDCompositionGaussianBlurEffectTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDCompositionGaussianBlurEffect" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDCompositionGaussianBlurEffect).GUID, Is.EqualTo(IID_IDCompositionGaussianBlurEffect));
        }

        /// <summary>Validates that the <see cref="IDCompositionGaussianBlurEffect" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDCompositionGaussianBlurEffect>(), Is.EqualTo(sizeof(IDCompositionGaussianBlurEffect)));
        }

        /// <summary>Validates that the <see cref="IDCompositionGaussianBlurEffect" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDCompositionGaussianBlurEffect).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDCompositionGaussianBlurEffect" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDCompositionGaussianBlurEffect), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDCompositionGaussianBlurEffect), Is.EqualTo(4));
            }
        }
    }
}
