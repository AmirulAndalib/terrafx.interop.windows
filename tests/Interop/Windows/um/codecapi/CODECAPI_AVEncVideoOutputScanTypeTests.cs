// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CODECAPI_AVEncVideoOutputScanType" /> struct.</summary>
    public static unsafe class CODECAPI_AVEncVideoOutputScanTypeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="CODECAPI_AVEncVideoOutputScanType" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(CODECAPI_AVEncVideoOutputScanType).GUID, Is.EqualTo(STATIC_CODECAPI_AVEncVideoOutputScanType));
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncVideoOutputScanType" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CODECAPI_AVEncVideoOutputScanType>(), Is.EqualTo(sizeof(CODECAPI_AVEncVideoOutputScanType)));
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncVideoOutputScanType" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CODECAPI_AVEncVideoOutputScanType).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncVideoOutputScanType" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CODECAPI_AVEncVideoOutputScanType), Is.EqualTo(1));
        }
    }
}
