// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="GET_MEDIA_TYPES" /> struct.</summary>
    public static unsafe class GET_MEDIA_TYPESTests
    {
        /// <summary>Validates that the <see cref="GET_MEDIA_TYPES" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<GET_MEDIA_TYPES>(), Is.EqualTo(sizeof(GET_MEDIA_TYPES)));
        }

        /// <summary>Validates that the <see cref="GET_MEDIA_TYPES" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(GET_MEDIA_TYPES).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="GET_MEDIA_TYPES" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(GET_MEDIA_TYPES), Is.EqualTo(40));
        }
    }
}
