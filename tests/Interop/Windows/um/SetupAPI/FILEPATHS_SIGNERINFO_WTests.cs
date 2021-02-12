// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="FILEPATHS_SIGNERINFO_W" /> struct.</summary>
    public static unsafe class FILEPATHS_SIGNERINFO_WTests
    {
        /// <summary>Validates that the <see cref="FILEPATHS_SIGNERINFO_W" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<FILEPATHS_SIGNERINFO_W>(), Is.EqualTo(sizeof(FILEPATHS_SIGNERINFO_W)));
        }

        /// <summary>Validates that the <see cref="FILEPATHS_SIGNERINFO_W" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(FILEPATHS_SIGNERINFO_W).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="FILEPATHS_SIGNERINFO_W" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(FILEPATHS_SIGNERINFO_W), Is.EqualTo(48));
            }
            else
            {
                Assert.That(sizeof(FILEPATHS_SIGNERINFO_W), Is.EqualTo(28));
            }
        }
    }
}
