// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMAGEHLP_MODULE" /> struct.</summary>
    public static unsafe partial class IMAGEHLP_MODULETests
    {
        /// <summary>Validates that the <see cref="IMAGEHLP_MODULE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMAGEHLP_MODULE>(), Is.EqualTo(sizeof(IMAGEHLP_MODULE)));
        }

        /// <summary>Validates that the <see cref="IMAGEHLP_MODULE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMAGEHLP_MODULE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMAGEHLP_MODULE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(IMAGEHLP_MODULE), Is.EqualTo(572));
        }
    }
}
