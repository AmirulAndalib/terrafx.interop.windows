// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CODECAPI_AVEncMP12MuxNumStreams" /> struct.</summary>
    public static unsafe class CODECAPI_AVEncMP12MuxNumStreamsTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="CODECAPI_AVEncMP12MuxNumStreams" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(CODECAPI_AVEncMP12MuxNumStreams).GUID, Is.EqualTo(STATIC_CODECAPI_AVEncMP12MuxNumStreams));
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncMP12MuxNumStreams" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CODECAPI_AVEncMP12MuxNumStreams>(), Is.EqualTo(sizeof(CODECAPI_AVEncMP12MuxNumStreams)));
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncMP12MuxNumStreams" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CODECAPI_AVEncMP12MuxNumStreams).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncMP12MuxNumStreams" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CODECAPI_AVEncMP12MuxNumStreams), Is.EqualTo(1));
        }
    }
}
