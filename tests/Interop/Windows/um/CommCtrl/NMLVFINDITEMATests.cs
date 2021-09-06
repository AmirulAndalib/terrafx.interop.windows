// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="NMLVFINDITEMA" /> struct.</summary>
    public static unsafe class NMLVFINDITEMATests
    {
        /// <summary>Validates that the <see cref="NMLVFINDITEMA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<NMLVFINDITEMA>(), Is.EqualTo(sizeof(NMLVFINDITEMA)));
        }

        /// <summary>Validates that the <see cref="NMLVFINDITEMA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(NMLVFINDITEMA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="NMLVFINDITEMA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(NMLVFINDITEMA), Is.EqualTo(72));
            }
            else
            {
                Assert.That(sizeof(NMLVFINDITEMA), Is.EqualTo(40));
            }
        }
    }
}
