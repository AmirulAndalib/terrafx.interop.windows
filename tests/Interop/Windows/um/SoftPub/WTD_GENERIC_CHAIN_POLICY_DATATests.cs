// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WTD_GENERIC_CHAIN_POLICY_DATA" /> struct.</summary>
    public static unsafe class WTD_GENERIC_CHAIN_POLICY_DATATests
    {
        /// <summary>Validates that the <see cref="WTD_GENERIC_CHAIN_POLICY_DATA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WTD_GENERIC_CHAIN_POLICY_DATA>(), Is.EqualTo(sizeof(WTD_GENERIC_CHAIN_POLICY_DATA)));
        }

        /// <summary>Validates that the <see cref="WTD_GENERIC_CHAIN_POLICY_DATA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WTD_GENERIC_CHAIN_POLICY_DATA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WTD_GENERIC_CHAIN_POLICY_DATA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(WTD_GENERIC_CHAIN_POLICY_DATA), Is.EqualTo(40));
            }
            else
            {
                Assert.That(sizeof(WTD_GENERIC_CHAIN_POLICY_DATA), Is.EqualTo(20));
            }
        }
    }
}
