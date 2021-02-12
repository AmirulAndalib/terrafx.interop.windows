// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CWPRETSTRUCT" /> struct.</summary>
    public static unsafe class CWPRETSTRUCTTests
    {
        /// <summary>Validates that the <see cref="CWPRETSTRUCT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CWPRETSTRUCT>(), Is.EqualTo(sizeof(CWPRETSTRUCT)));
        }

        /// <summary>Validates that the <see cref="CWPRETSTRUCT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CWPRETSTRUCT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CWPRETSTRUCT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(CWPRETSTRUCT), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(CWPRETSTRUCT), Is.EqualTo(20));
            }
        }
    }
}
