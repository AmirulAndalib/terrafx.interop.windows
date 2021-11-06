// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="STACKFRAME64" /> struct.</summary>
    public static unsafe partial class STACKFRAME64Tests
    {
        /// <summary>Validates that the <see cref="STACKFRAME64" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<STACKFRAME64>(), Is.EqualTo(sizeof(STACKFRAME64)));
        }

        /// <summary>Validates that the <see cref="STACKFRAME64" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(STACKFRAME64).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="STACKFRAME64" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(STACKFRAME64), Is.EqualTo(264));
        }
    }
}
