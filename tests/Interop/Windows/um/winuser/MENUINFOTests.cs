// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MENUINFO" /> struct.</summary>
    public static unsafe class MENUINFOTests
    {
        /// <summary>Validates that the <see cref="MENUINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MENUINFO>(), Is.EqualTo(sizeof(MENUINFO)));
        }

        /// <summary>Validates that the <see cref="MENUINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MENUINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MENUINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(MENUINFO), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(MENUINFO), Is.EqualTo(28));
            }
        }
    }
}
