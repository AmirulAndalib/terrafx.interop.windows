// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIFactory" /> struct.</summary>
    public static unsafe class IDXGIFactoryTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIFactory" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDXGIFactory).GUID, Is.EqualTo(IID_IDXGIFactory));
        }

        /// <summary>Validates that the <see cref="IDXGIFactory" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDXGIFactory>(), Is.EqualTo(sizeof(IDXGIFactory)));
        }

        /// <summary>Validates that the <see cref="IDXGIFactory" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIFactory).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDXGIFactory" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDXGIFactory), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDXGIFactory), Is.EqualTo(4));
            }
        }
    }
}
