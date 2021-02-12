// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="MsftStreamPrng001" /> struct.</summary>
    public static unsafe class MsftStreamPrng001Tests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="MsftStreamPrng001" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(MsftStreamPrng001).GUID, Is.EqualTo(CLSID_MsftStreamPrng001));
        }

        /// <summary>Validates that the <see cref="MsftStreamPrng001" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MsftStreamPrng001>(), Is.EqualTo(sizeof(MsftStreamPrng001)));
        }

        /// <summary>Validates that the <see cref="MsftStreamPrng001" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MsftStreamPrng001).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MsftStreamPrng001" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MsftStreamPrng001), Is.EqualTo(1));
        }
    }
}
