// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="MsftStreamZero" /> struct.</summary>
    public static unsafe partial class MsftStreamZeroTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="MsftStreamZero" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(MsftStreamZero).GUID, Is.EqualTo(CLSID_MsftStreamZero));
        }

        /// <summary>Validates that the <see cref="MsftStreamZero" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<MsftStreamZero>(), Is.EqualTo(sizeof(MsftStreamZero)));
        }

        /// <summary>Validates that the <see cref="MsftStreamZero" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(MsftStreamZero).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="MsftStreamZero" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(MsftStreamZero), Is.EqualTo(1));
        }
    }
}
