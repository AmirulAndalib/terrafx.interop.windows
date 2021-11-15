// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="TXFS_START_RM_INFORMATION" /> struct.</summary>
    public static unsafe partial class TXFS_START_RM_INFORMATIONTests
    {
        /// <summary>Validates that the <see cref="TXFS_START_RM_INFORMATION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TXFS_START_RM_INFORMATION>(), Is.EqualTo(sizeof(TXFS_START_RM_INFORMATION)));
        }

        /// <summary>Validates that the <see cref="TXFS_START_RM_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TXFS_START_RM_INFORMATION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TXFS_START_RM_INFORMATION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TXFS_START_RM_INFORMATION), Is.EqualTo(48));
        }
    }
}