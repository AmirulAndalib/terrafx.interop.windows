// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CODECAPI_AVEncVideoCTBSize" /> struct.</summary>
    public static unsafe class CODECAPI_AVEncVideoCTBSizeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="CODECAPI_AVEncVideoCTBSize" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(CODECAPI_AVEncVideoCTBSize).GUID, Is.EqualTo(STATIC_CODECAPI_AVEncVideoCTBSize));
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncVideoCTBSize" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CODECAPI_AVEncVideoCTBSize>(), Is.EqualTo(sizeof(CODECAPI_AVEncVideoCTBSize)));
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncVideoCTBSize" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CODECAPI_AVEncVideoCTBSize).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CODECAPI_AVEncVideoCTBSize" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CODECAPI_AVEncVideoCTBSize), Is.EqualTo(1));
        }
    }
}
