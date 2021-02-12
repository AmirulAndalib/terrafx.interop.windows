// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DDSURFACEDESC" /> struct.</summary>
    public static unsafe class DDSURFACEDESCTests
    {
        /// <summary>Validates that the <see cref="DDSURFACEDESC" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DDSURFACEDESC>(), Is.EqualTo(sizeof(DDSURFACEDESC)));
        }

        /// <summary>Validates that the <see cref="DDSURFACEDESC" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DDSURFACEDESC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DDSURFACEDESC" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DDSURFACEDESC), Is.EqualTo(120));
            }
            else
            {
                Assert.That(sizeof(DDSURFACEDESC), Is.EqualTo(108));
            }
        }
    }
}
