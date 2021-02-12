// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="KSDATAFORMAT_SUBTYPE_IEEE_FLOAT" /> struct.</summary>
    public static unsafe class KSDATAFORMAT_SUBTYPE_IEEE_FLOATTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="KSDATAFORMAT_SUBTYPE_IEEE_FLOAT" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(KSDATAFORMAT_SUBTYPE_IEEE_FLOAT).GUID, Is.EqualTo(STATIC_KSDATAFORMAT_SUBTYPE_IEEE_FLOAT));
        }

        /// <summary>Validates that the <see cref="KSDATAFORMAT_SUBTYPE_IEEE_FLOAT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<KSDATAFORMAT_SUBTYPE_IEEE_FLOAT>(), Is.EqualTo(sizeof(KSDATAFORMAT_SUBTYPE_IEEE_FLOAT)));
        }

        /// <summary>Validates that the <see cref="KSDATAFORMAT_SUBTYPE_IEEE_FLOAT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(KSDATAFORMAT_SUBTYPE_IEEE_FLOAT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="KSDATAFORMAT_SUBTYPE_IEEE_FLOAT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(KSDATAFORMAT_SUBTYPE_IEEE_FLOAT), Is.EqualTo(1));
        }
    }
}
