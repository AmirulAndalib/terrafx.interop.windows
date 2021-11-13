// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="SVGPointList" /> struct.</summary>
    public static unsafe partial class SVGPointListTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="SVGPointList" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(SVGPointList).GUID, Is.EqualTo(IID_SVGPointList));
        }

        /// <summary>Validates that the <see cref="SVGPointList" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<SVGPointList>(), Is.EqualTo(sizeof(SVGPointList)));
        }

        /// <summary>Validates that the <see cref="SVGPointList" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(SVGPointList).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="SVGPointList" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(SVGPointList), Is.EqualTo(1));
        }
    }
}
