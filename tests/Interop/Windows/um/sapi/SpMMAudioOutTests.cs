// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="SpMMAudioOut" /> struct.</summary>
    public static unsafe class SpMMAudioOutTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="SpMMAudioOut" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(SpMMAudioOut).GUID, Is.EqualTo(CLSID_SpMMAudioOut));
        }

        /// <summary>Validates that the <see cref="SpMMAudioOut" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SpMMAudioOut>(), Is.EqualTo(sizeof(SpMMAudioOut)));
        }

        /// <summary>Validates that the <see cref="SpMMAudioOut" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SpMMAudioOut).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SpMMAudioOut" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SpMMAudioOut), Is.EqualTo(1));
        }
    }
}
