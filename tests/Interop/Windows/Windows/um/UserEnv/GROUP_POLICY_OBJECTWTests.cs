// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="GROUP_POLICY_OBJECTW" /> struct.</summary>
    public static unsafe partial class GROUP_POLICY_OBJECTWTests
    {
        /// <summary>Validates that the <see cref="GROUP_POLICY_OBJECTW" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<GROUP_POLICY_OBJECTW>(), Is.EqualTo(sizeof(GROUP_POLICY_OBJECTW)));
        }

        /// <summary>Validates that the <see cref="GROUP_POLICY_OBJECTW" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(GROUP_POLICY_OBJECTW).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="GROUP_POLICY_OBJECTW" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(GROUP_POLICY_OBJECTW), Is.EqualTo(184));
            }
            else
            {
                Assert.That(sizeof(GROUP_POLICY_OBJECTW), Is.EqualTo(148));
            }
        }
    }
}
