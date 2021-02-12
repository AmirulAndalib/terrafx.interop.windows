// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MIXERCONTROLDETAILS_LISTTEXTA" /> struct.</summary>
    public static unsafe class MIXERCONTROLDETAILS_LISTTEXTATests
    {
        /// <summary>Validates that the <see cref="MIXERCONTROLDETAILS_LISTTEXTA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MIXERCONTROLDETAILS_LISTTEXTA>(), Is.EqualTo(sizeof(MIXERCONTROLDETAILS_LISTTEXTA)));
        }

        /// <summary>Validates that the <see cref="MIXERCONTROLDETAILS_LISTTEXTA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MIXERCONTROLDETAILS_LISTTEXTA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MIXERCONTROLDETAILS_LISTTEXTA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MIXERCONTROLDETAILS_LISTTEXTA), Is.EqualTo(72));
        }
    }
}
