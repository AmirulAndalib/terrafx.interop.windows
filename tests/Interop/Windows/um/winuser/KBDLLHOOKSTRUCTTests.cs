// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="KBDLLHOOKSTRUCT" /> struct.</summary>
    public static unsafe class KBDLLHOOKSTRUCTTests
    {
        /// <summary>Validates that the <see cref="KBDLLHOOKSTRUCT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<KBDLLHOOKSTRUCT>(), Is.EqualTo(sizeof(KBDLLHOOKSTRUCT)));
        }

        /// <summary>Validates that the <see cref="KBDLLHOOKSTRUCT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(KBDLLHOOKSTRUCT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="KBDLLHOOKSTRUCT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(KBDLLHOOKSTRUCT), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(KBDLLHOOKSTRUCT), Is.EqualTo(20));
            }
        }
    }
}
