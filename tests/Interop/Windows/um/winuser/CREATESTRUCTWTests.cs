// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CREATESTRUCTW" /> struct.</summary>
    public static unsafe class CREATESTRUCTWTests
    {
        /// <summary>Validates that the <see cref="CREATESTRUCTW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CREATESTRUCTW>(), Is.EqualTo(sizeof(CREATESTRUCTW)));
        }

        /// <summary>Validates that the <see cref="CREATESTRUCTW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CREATESTRUCTW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CREATESTRUCTW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CREATESTRUCTW), Is.EqualTo(80));
            }
            else
            {
                Assert.That(sizeof(CREATESTRUCTW), Is.EqualTo(48));
            }
        }
    }
}
