// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/RemoteSystemsInterop.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ICorrelationVectorInformation" /> struct.</summary>
    public static unsafe class ICorrelationVectorInformationTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ICorrelationVectorInformation" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ICorrelationVectorInformation).GUID, Is.EqualTo(IID_ICorrelationVectorInformation));
        }

        /// <summary>Validates that the <see cref="ICorrelationVectorInformation" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ICorrelationVectorInformation>(), Is.EqualTo(sizeof(ICorrelationVectorInformation)));
        }

        /// <summary>Validates that the <see cref="ICorrelationVectorInformation" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ICorrelationVectorInformation).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ICorrelationVectorInformation" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ICorrelationVectorInformation), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ICorrelationVectorInformation), Is.EqualTo(4));
            }
        }
    }
}
