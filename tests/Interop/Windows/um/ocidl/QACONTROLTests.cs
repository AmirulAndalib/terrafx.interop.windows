// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OCIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="QACONTROL" /> struct.</summary>
    public static unsafe class QACONTROLTests
    {
        /// <summary>Validates that the <see cref="QACONTROL" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<QACONTROL>(), Is.EqualTo(sizeof(QACONTROL)));
        }

        /// <summary>Validates that the <see cref="QACONTROL" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(QACONTROL).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="QACONTROL" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(QACONTROL), Is.EqualTo(24));
        }
    }
}
