// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxgidebug.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDXGIDebug" /> struct.</summary>
    public static unsafe class IDXGIDebugTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIDebug" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDXGIDebug).GUID, Is.EqualTo(IID_IDXGIDebug));
        }

        /// <summary>Validates that the <see cref="IDXGIDebug" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDXGIDebug>(), Is.EqualTo(sizeof(IDXGIDebug)));
        }

        /// <summary>Validates that the <see cref="IDXGIDebug" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDXGIDebug).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDXGIDebug" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDXGIDebug), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDXGIDebug), Is.EqualTo(4));
            }
        }
    }
}
