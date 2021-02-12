// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ID2D1LinearGradientBrush" /> struct.</summary>
    public static unsafe class ID2D1LinearGradientBrushTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID2D1LinearGradientBrush" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ID2D1LinearGradientBrush).GUID, Is.EqualTo(IID_ID2D1LinearGradientBrush));
        }

        /// <summary>Validates that the <see cref="ID2D1LinearGradientBrush" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ID2D1LinearGradientBrush>(), Is.EqualTo(sizeof(ID2D1LinearGradientBrush)));
        }

        /// <summary>Validates that the <see cref="ID2D1LinearGradientBrush" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ID2D1LinearGradientBrush).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ID2D1LinearGradientBrush" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ID2D1LinearGradientBrush), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ID2D1LinearGradientBrush), Is.EqualTo(4));
            }
        }
    }
}
