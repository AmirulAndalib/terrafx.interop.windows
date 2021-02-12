// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MIDIOUTCAPSW" /> struct.</summary>
    public static unsafe class MIDIOUTCAPSWTests
    {
        /// <summary>Validates that the <see cref="MIDIOUTCAPSW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MIDIOUTCAPSW>(), Is.EqualTo(sizeof(MIDIOUTCAPSW)));
        }

        /// <summary>Validates that the <see cref="MIDIOUTCAPSW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MIDIOUTCAPSW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MIDIOUTCAPSW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MIDIOUTCAPSW), Is.EqualTo(84));
        }
    }
}
