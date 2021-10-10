// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IUnsecuredApartment" /> struct.</summary>
    public static unsafe class IUnsecuredApartmentTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IUnsecuredApartment" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IUnsecuredApartment).GUID, Is.EqualTo(IID_IUnsecuredApartment));
        }

        /// <summary>Validates that the <see cref="IUnsecuredApartment" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IUnsecuredApartment>(), Is.EqualTo(sizeof(IUnsecuredApartment)));
        }

        /// <summary>Validates that the <see cref="IUnsecuredApartment" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IUnsecuredApartment).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IUnsecuredApartment" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IUnsecuredApartment), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IUnsecuredApartment), Is.EqualTo(4));
            }
        }
    }
}
