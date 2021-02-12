// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SAFEARR_HAVEIID" /> struct.</summary>
    public static unsafe class SAFEARR_HAVEIIDTests
    {
        /// <summary>Validates that the <see cref="SAFEARR_HAVEIID" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SAFEARR_HAVEIID>(), Is.EqualTo(sizeof(SAFEARR_HAVEIID)));
        }

        /// <summary>Validates that the <see cref="SAFEARR_HAVEIID" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SAFEARR_HAVEIID).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SAFEARR_HAVEIID" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(SAFEARR_HAVEIID), Is.EqualTo(32));
            }
            else
            {
                Assert.That(sizeof(SAFEARR_HAVEIID), Is.EqualTo(24));
            }
        }
    }
}
