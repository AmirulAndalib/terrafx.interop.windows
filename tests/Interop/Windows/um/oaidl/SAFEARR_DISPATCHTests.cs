// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SAFEARR_DISPATCH" /> struct.</summary>
    public static unsafe class SAFEARR_DISPATCHTests
    {
        /// <summary>Validates that the <see cref="SAFEARR_DISPATCH" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SAFEARR_DISPATCH>(), Is.EqualTo(sizeof(SAFEARR_DISPATCH)));
        }

        /// <summary>Validates that the <see cref="SAFEARR_DISPATCH" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SAFEARR_DISPATCH).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SAFEARR_DISPATCH" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SAFEARR_DISPATCH), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(SAFEARR_DISPATCH), Is.EqualTo(8));
            }
        }
    }
}
