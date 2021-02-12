// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="PROCESS_MITIGATION_FONT_DISABLE_POLICY" /> struct.</summary>
    public static unsafe class PROCESS_MITIGATION_FONT_DISABLE_POLICYTests
    {
        /// <summary>Validates that the <see cref="PROCESS_MITIGATION_FONT_DISABLE_POLICY" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<PROCESS_MITIGATION_FONT_DISABLE_POLICY>(), Is.EqualTo(sizeof(PROCESS_MITIGATION_FONT_DISABLE_POLICY)));
        }

        /// <summary>Validates that the <see cref="PROCESS_MITIGATION_FONT_DISABLE_POLICY" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(PROCESS_MITIGATION_FONT_DISABLE_POLICY).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="PROCESS_MITIGATION_FONT_DISABLE_POLICY" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(PROCESS_MITIGATION_FONT_DISABLE_POLICY), Is.EqualTo(4));
        }
    }
}
