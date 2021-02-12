// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DirectManipulationSharedManager" /> struct.</summary>
    public static unsafe class DirectManipulationSharedManagerTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DirectManipulationSharedManager" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(DirectManipulationSharedManager).GUID, Is.EqualTo(CLSID_DirectManipulationSharedManager));
        }

        /// <summary>Validates that the <see cref="DirectManipulationSharedManager" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DirectManipulationSharedManager>(), Is.EqualTo(sizeof(DirectManipulationSharedManager)));
        }

        /// <summary>Validates that the <see cref="DirectManipulationSharedManager" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DirectManipulationSharedManager).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DirectManipulationSharedManager" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(DirectManipulationSharedManager), Is.EqualTo(1));
        }
    }
}
