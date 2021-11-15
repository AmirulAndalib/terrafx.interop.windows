// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="WIN_TRUST_SUBJECT_FILE" /> struct.</summary>
    public static unsafe partial class WIN_TRUST_SUBJECT_FILETests
    {
        /// <summary>Validates that the <see cref="WIN_TRUST_SUBJECT_FILE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WIN_TRUST_SUBJECT_FILE>(), Is.EqualTo(sizeof(WIN_TRUST_SUBJECT_FILE)));
        }

        /// <summary>Validates that the <see cref="WIN_TRUST_SUBJECT_FILE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WIN_TRUST_SUBJECT_FILE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WIN_TRUST_SUBJECT_FILE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(WIN_TRUST_SUBJECT_FILE), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(WIN_TRUST_SUBJECT_FILE), Is.EqualTo(8));
            }
        }
    }
}