// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IWbemUnsecuredApartment" /> struct.</summary>
    public static unsafe class IWbemUnsecuredApartmentTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWbemUnsecuredApartment" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IWbemUnsecuredApartment).GUID, Is.EqualTo(IID_IWbemUnsecuredApartment));
        }

        /// <summary>Validates that the <see cref="IWbemUnsecuredApartment" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IWbemUnsecuredApartment>(), Is.EqualTo(sizeof(IWbemUnsecuredApartment)));
        }

        /// <summary>Validates that the <see cref="IWbemUnsecuredApartment" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IWbemUnsecuredApartment).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IWbemUnsecuredApartment" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IWbemUnsecuredApartment), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IWbemUnsecuredApartment), Is.EqualTo(4));
            }
        }
    }
}
