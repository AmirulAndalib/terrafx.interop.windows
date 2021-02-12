// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDCompositionDevice" /> struct.</summary>
    public static unsafe class IDCompositionDeviceTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDCompositionDevice" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDCompositionDevice).GUID, Is.EqualTo(IID_IDCompositionDevice));
        }

        /// <summary>Validates that the <see cref="IDCompositionDevice" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDCompositionDevice>(), Is.EqualTo(sizeof(IDCompositionDevice)));
        }

        /// <summary>Validates that the <see cref="IDCompositionDevice" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDCompositionDevice).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDCompositionDevice" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDCompositionDevice), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDCompositionDevice), Is.EqualTo(4));
            }
        }
    }
}
