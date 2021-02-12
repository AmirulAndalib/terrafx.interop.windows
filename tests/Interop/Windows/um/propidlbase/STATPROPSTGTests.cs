// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="STATPROPSTG" /> struct.</summary>
    public static unsafe class STATPROPSTGTests
    {
        /// <summary>Validates that the <see cref="STATPROPSTG" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<STATPROPSTG>(), Is.EqualTo(sizeof(STATPROPSTG)));
        }

        /// <summary>Validates that the <see cref="STATPROPSTG" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(STATPROPSTG).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="STATPROPSTG" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(STATPROPSTG), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(STATPROPSTG), Is.EqualTo(12));
            }
        }
    }
}
