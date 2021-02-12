// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDCompositionTurbulenceEffect" /> struct.</summary>
    public static unsafe class IDCompositionTurbulenceEffectTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDCompositionTurbulenceEffect" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDCompositionTurbulenceEffect).GUID, Is.EqualTo(IID_IDCompositionTurbulenceEffect));
        }

        /// <summary>Validates that the <see cref="IDCompositionTurbulenceEffect" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDCompositionTurbulenceEffect>(), Is.EqualTo(sizeof(IDCompositionTurbulenceEffect)));
        }

        /// <summary>Validates that the <see cref="IDCompositionTurbulenceEffect" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDCompositionTurbulenceEffect).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDCompositionTurbulenceEffect" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDCompositionTurbulenceEffect), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDCompositionTurbulenceEffect), Is.EqualTo(4));
            }
        }
    }
}
