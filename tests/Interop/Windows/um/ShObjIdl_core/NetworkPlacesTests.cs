// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="NetworkPlaces" /> struct.</summary>
    public static unsafe class NetworkPlacesTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="NetworkPlaces" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(NetworkPlaces).GUID, Is.EqualTo(IID_NetworkPlaces));
        }

        /// <summary>Validates that the <see cref="NetworkPlaces" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<NetworkPlaces>(), Is.EqualTo(sizeof(NetworkPlaces)));
        }

        /// <summary>Validates that the <see cref="NetworkPlaces" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(NetworkPlaces).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="NetworkPlaces" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(NetworkPlaces), Is.EqualTo(1));
        }
    }
}
