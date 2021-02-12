// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DELETEITEMSTRUCT" /> struct.</summary>
    public static unsafe class DELETEITEMSTRUCTTests
    {
        /// <summary>Validates that the <see cref="DELETEITEMSTRUCT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DELETEITEMSTRUCT>(), Is.EqualTo(sizeof(DELETEITEMSTRUCT)));
        }

        /// <summary>Validates that the <see cref="DELETEITEMSTRUCT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DELETEITEMSTRUCT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DELETEITEMSTRUCT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DELETEITEMSTRUCT), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(DELETEITEMSTRUCT), Is.EqualTo(20));
            }
        }
    }
}
