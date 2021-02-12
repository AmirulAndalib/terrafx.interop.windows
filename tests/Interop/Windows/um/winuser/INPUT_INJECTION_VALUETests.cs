// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="INPUT_INJECTION_VALUE" /> struct.</summary>
    public static unsafe class INPUT_INJECTION_VALUETests
    {
        /// <summary>Validates that the <see cref="INPUT_INJECTION_VALUE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<INPUT_INJECTION_VALUE>(), Is.EqualTo(sizeof(INPUT_INJECTION_VALUE)));
        }

        /// <summary>Validates that the <see cref="INPUT_INJECTION_VALUE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(INPUT_INJECTION_VALUE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="INPUT_INJECTION_VALUE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(INPUT_INJECTION_VALUE), Is.EqualTo(12));
        }
    }
}
