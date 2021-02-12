// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDirectDraw7" /> struct.</summary>
    public static unsafe class IDirectDraw7Tests
    {
        /// <summary>Validates that the <see cref="IDirectDraw7" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDirectDraw7>(), Is.EqualTo(sizeof(IDirectDraw7)));
        }

        /// <summary>Validates that the <see cref="IDirectDraw7" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDirectDraw7).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDirectDraw7" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDirectDraw7), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDirectDraw7), Is.EqualTo(4));
            }
        }
    }
}
