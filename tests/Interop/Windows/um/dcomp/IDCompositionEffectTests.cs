// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDCompositionEffect" /> struct.</summary>
    public static unsafe class IDCompositionEffectTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDCompositionEffect" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDCompositionEffect).GUID, Is.EqualTo(IID_IDCompositionEffect));
        }

        /// <summary>Validates that the <see cref="IDCompositionEffect" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDCompositionEffect>(), Is.EqualTo(sizeof(IDCompositionEffect)));
        }

        /// <summary>Validates that the <see cref="IDCompositionEffect" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDCompositionEffect).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDCompositionEffect" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDCompositionEffect), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDCompositionEffect), Is.EqualTo(4));
            }
        }
    }
}
