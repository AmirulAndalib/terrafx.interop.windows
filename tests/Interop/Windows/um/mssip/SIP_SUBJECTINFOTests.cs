// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SIP_SUBJECTINFO" /> struct.</summary>
    public static unsafe class SIP_SUBJECTINFOTests
    {
        /// <summary>Validates that the <see cref="SIP_SUBJECTINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SIP_SUBJECTINFO>(), Is.EqualTo(sizeof(SIP_SUBJECTINFO)));
        }

        /// <summary>Validates that the <see cref="SIP_SUBJECTINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SIP_SUBJECTINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SIP_SUBJECTINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SIP_SUBJECTINFO), Is.EqualTo(128));
            }
            else
            {
                Assert.That(sizeof(SIP_SUBJECTINFO), Is.EqualTo(80));
            }
        }
    }
}
