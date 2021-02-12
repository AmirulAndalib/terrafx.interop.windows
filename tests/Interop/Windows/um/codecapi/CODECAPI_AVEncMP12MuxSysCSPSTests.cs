// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CODECAPI_AVEncMP12MuxSysCSPS" /> struct.</summary>
    public static unsafe class CODECAPI_AVEncMP12MuxSysCSPSTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="CODECAPI_AVEncMP12MuxSysCSPS" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(CODECAPI_AVEncMP12MuxSysCSPS).GUID, Is.EqualTo(STATIC_CODECAPI_AVEncMP12MuxSysCSPS));
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncMP12MuxSysCSPS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CODECAPI_AVEncMP12MuxSysCSPS>(), Is.EqualTo(sizeof(CODECAPI_AVEncMP12MuxSysCSPS)));
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncMP12MuxSysCSPS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CODECAPI_AVEncMP12MuxSysCSPS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncMP12MuxSysCSPS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CODECAPI_AVEncMP12MuxSysCSPS), Is.EqualTo(1));
        }
    }
}
