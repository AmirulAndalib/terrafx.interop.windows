// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CODECAPI_AVEncMP12MuxLargestPacketSize" /> struct.</summary>
    public static unsafe class CODECAPI_AVEncMP12MuxLargestPacketSizeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="CODECAPI_AVEncMP12MuxLargestPacketSize" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(CODECAPI_AVEncMP12MuxLargestPacketSize).GUID, Is.EqualTo(STATIC_CODECAPI_AVEncMP12MuxLargestPacketSize));
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncMP12MuxLargestPacketSize" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CODECAPI_AVEncMP12MuxLargestPacketSize>(), Is.EqualTo(sizeof(CODECAPI_AVEncMP12MuxLargestPacketSize)));
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncMP12MuxLargestPacketSize" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CODECAPI_AVEncMP12MuxLargestPacketSize).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncMP12MuxLargestPacketSize" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CODECAPI_AVEncMP12MuxLargestPacketSize), Is.EqualTo(1));
        }
    }
}
