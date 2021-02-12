// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDCompositionTableTransferEffect" /> struct.</summary>
    public static unsafe class IDCompositionTableTransferEffectTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDCompositionTableTransferEffect" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDCompositionTableTransferEffect).GUID, Is.EqualTo(IID_IDCompositionTableTransferEffect));
        }

        /// <summary>Validates that the <see cref="IDCompositionTableTransferEffect" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDCompositionTableTransferEffect>(), Is.EqualTo(sizeof(IDCompositionTableTransferEffect)));
        }

        /// <summary>Validates that the <see cref="IDCompositionTableTransferEffect" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDCompositionTableTransferEffect).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDCompositionTableTransferEffect" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDCompositionTableTransferEffect), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDCompositionTableTransferEffect), Is.EqualTo(4));
            }
        }
    }
}
