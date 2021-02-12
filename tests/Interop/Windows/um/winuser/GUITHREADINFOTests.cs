// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="GUITHREADINFO" /> struct.</summary>
    public static unsafe class GUITHREADINFOTests
    {
        /// <summary>Validates that the <see cref="GUITHREADINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<GUITHREADINFO>(), Is.EqualTo(sizeof(GUITHREADINFO)));
        }

        /// <summary>Validates that the <see cref="GUITHREADINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(GUITHREADINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="GUITHREADINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(GUITHREADINFO), Is.EqualTo(72));
            }
            else
            {
                Assert.That(sizeof(GUITHREADINFO), Is.EqualTo(48));
            }
        }
    }
}
