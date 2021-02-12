// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MIXERCAPS2A" /> struct.</summary>
    public static unsafe class MIXERCAPS2ATests
    {
        /// <summary>Validates that the <see cref="MIXERCAPS2A" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MIXERCAPS2A>(), Is.EqualTo(sizeof(MIXERCAPS2A)));
        }

        /// <summary>Validates that the <see cref="MIXERCAPS2A" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MIXERCAPS2A).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MIXERCAPS2A" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MIXERCAPS2A), Is.EqualTo(96));
        }
    }
}
