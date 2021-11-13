// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="DELEGATEITEMID" /> struct.</summary>
    public static unsafe partial class DELEGATEITEMIDTests
    {
        /// <summary>Validates that the <see cref="DELEGATEITEMID" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DELEGATEITEMID>(), Is.EqualTo(sizeof(DELEGATEITEMID)));
        }

        /// <summary>Validates that the <see cref="DELEGATEITEMID" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DELEGATEITEMID).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DELEGATEITEMID" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DELEGATEITEMID), Is.EqualTo(7));
        }
    }
}
