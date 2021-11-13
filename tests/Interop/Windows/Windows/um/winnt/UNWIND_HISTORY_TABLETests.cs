// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="UNWIND_HISTORY_TABLE" /> struct.</summary>
    public static unsafe partial class UNWIND_HISTORY_TABLETests
    {
        /// <summary>Validates that the <see cref="UNWIND_HISTORY_TABLE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<UNWIND_HISTORY_TABLE>(), Is.EqualTo(sizeof(UNWIND_HISTORY_TABLE)));
        }

        /// <summary>Validates that the <see cref="UNWIND_HISTORY_TABLE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(UNWIND_HISTORY_TABLE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="UNWIND_HISTORY_TABLE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(UNWIND_HISTORY_TABLE), Is.EqualTo(216));
            }
            else
            {
                Assert.That(sizeof(UNWIND_HISTORY_TABLE), Is.EqualTo(112));
            }
        }
    }
}
