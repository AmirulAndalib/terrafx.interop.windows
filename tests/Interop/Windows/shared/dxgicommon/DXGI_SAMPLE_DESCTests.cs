// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgicommon.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DXGI_SAMPLE_DESC" /> struct.</summary>
    public static unsafe class DXGI_SAMPLE_DESCTests
    {
        /// <summary>Validates that the <see cref="DXGI_SAMPLE_DESC" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DXGI_SAMPLE_DESC>(), Is.EqualTo(sizeof(DXGI_SAMPLE_DESC)));
        }

        /// <summary>Validates that the <see cref="DXGI_SAMPLE_DESC" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DXGI_SAMPLE_DESC).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DXGI_SAMPLE_DESC" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DXGI_SAMPLE_DESC), Is.EqualTo(8));
        }
    }
}
