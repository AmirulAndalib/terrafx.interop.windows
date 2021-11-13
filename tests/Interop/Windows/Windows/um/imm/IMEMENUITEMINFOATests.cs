// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMEMENUITEMINFOA" /> struct.</summary>
    public static unsafe partial class IMEMENUITEMINFOATests
    {
        /// <summary>Validates that the <see cref="IMEMENUITEMINFOA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMEMENUITEMINFOA>(), Is.EqualTo(sizeof(IMEMENUITEMINFOA)));
        }

        /// <summary>Validates that the <see cref="IMEMENUITEMINFOA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMEMENUITEMINFOA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMEMENUITEMINFOA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMEMENUITEMINFOA), Is.EqualTo(128));
            }
            else
            {
                Assert.That(sizeof(IMEMENUITEMINFOA), Is.EqualTo(112));
            }
        }
    }
}
