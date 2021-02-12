// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/processthreadsapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PROCESS_INFORMATION" /> struct.</summary>
    public static unsafe class PROCESS_INFORMATIONTests
    {
        /// <summary>Validates that the <see cref="PROCESS_INFORMATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PROCESS_INFORMATION>(), Is.EqualTo(sizeof(PROCESS_INFORMATION)));
        }

        /// <summary>Validates that the <see cref="PROCESS_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PROCESS_INFORMATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PROCESS_INFORMATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PROCESS_INFORMATION), Is.EqualTo(24));
            }
            else
            {
                Assert.That(sizeof(PROCESS_INFORMATION), Is.EqualTo(16));
            }
        }
    }
}
