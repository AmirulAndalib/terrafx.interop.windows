// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi3.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CONSOLE_HISTORY_INFO" /> struct.</summary>
    public static unsafe class CONSOLE_HISTORY_INFOTests
    {
        /// <summary>Validates that the <see cref="CONSOLE_HISTORY_INFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CONSOLE_HISTORY_INFO>(), Is.EqualTo(sizeof(CONSOLE_HISTORY_INFO)));
        }

        /// <summary>Validates that the <see cref="CONSOLE_HISTORY_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CONSOLE_HISTORY_INFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CONSOLE_HISTORY_INFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CONSOLE_HISTORY_INFO), Is.EqualTo(16));
        }
    }
}
