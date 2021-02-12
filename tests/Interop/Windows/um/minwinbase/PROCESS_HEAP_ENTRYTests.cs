// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PROCESS_HEAP_ENTRY" /> struct.</summary>
    public static unsafe class PROCESS_HEAP_ENTRYTests
    {
        /// <summary>Validates that the <see cref="PROCESS_HEAP_ENTRY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PROCESS_HEAP_ENTRY>(), Is.EqualTo(sizeof(PROCESS_HEAP_ENTRY)));
        }

        /// <summary>Validates that the <see cref="PROCESS_HEAP_ENTRY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PROCESS_HEAP_ENTRY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PROCESS_HEAP_ENTRY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(PROCESS_HEAP_ENTRY), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(PROCESS_HEAP_ENTRY), Is.EqualTo(28));
            }
        }
    }
}
