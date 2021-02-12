// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDCompositionSurfaceFactory" /> struct.</summary>
    public static unsafe class IDCompositionSurfaceFactoryTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDCompositionSurfaceFactory" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDCompositionSurfaceFactory).GUID, Is.EqualTo(IID_IDCompositionSurfaceFactory));
        }

        /// <summary>Validates that the <see cref="IDCompositionSurfaceFactory" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDCompositionSurfaceFactory>(), Is.EqualTo(sizeof(IDCompositionSurfaceFactory)));
        }

        /// <summary>Validates that the <see cref="IDCompositionSurfaceFactory" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDCompositionSurfaceFactory).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDCompositionSurfaceFactory" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDCompositionSurfaceFactory), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDCompositionSurfaceFactory), Is.EqualTo(4));
            }
        }
    }
}
