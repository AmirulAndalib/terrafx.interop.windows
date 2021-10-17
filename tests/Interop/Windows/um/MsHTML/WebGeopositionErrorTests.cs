// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="WebGeopositionError" /> struct.</summary>
    public static unsafe partial class WebGeopositionErrorTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="WebGeopositionError" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(WebGeopositionError).GUID, Is.EqualTo(IID_WebGeopositionError));
        }

        /// <summary>Validates that the <see cref="WebGeopositionError" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<WebGeopositionError>(), Is.EqualTo(sizeof(WebGeopositionError)));
        }

        /// <summary>Validates that the <see cref="WebGeopositionError" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(WebGeopositionError).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="WebGeopositionError" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(WebGeopositionError), Is.EqualTo(1));
        }
    }
}
