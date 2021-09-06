// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DLLVERSIONINFO" /> struct.</summary>
    public static unsafe class DLLVERSIONINFOTests
    {
        /// <summary>Validates that the <see cref="DLLVERSIONINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DLLVERSIONINFO>(), Is.EqualTo(sizeof(DLLVERSIONINFO)));
        }

        /// <summary>Validates that the <see cref="DLLVERSIONINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DLLVERSIONINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DLLVERSIONINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DLLVERSIONINFO), Is.EqualTo(20));
        }
    }
}
