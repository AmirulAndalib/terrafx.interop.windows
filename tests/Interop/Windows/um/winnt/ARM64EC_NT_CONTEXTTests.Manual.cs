// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ARM64EC_NT_CONTEXT" /> struct.</summary>
    public static unsafe partial class ARM64EC_NT_CONTEXTTests
    {
        /// <summary>Validates that the <see cref="ARM64EC_NT_CONTEXT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ARM64EC_NT_CONTEXT>(), Is.EqualTo(sizeof(ARM64EC_NT_CONTEXT)));
        }

        /// <summary>Validates that the <see cref="ARM64EC_NT_CONTEXT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ARM64EC_NT_CONTEXT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ARM64EC_NT_CONTEXT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(ARM64EC_NT_CONTEXT), Is.EqualTo(1232));
        }
    }
}
