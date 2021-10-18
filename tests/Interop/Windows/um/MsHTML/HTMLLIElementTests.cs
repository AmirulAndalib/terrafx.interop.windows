// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="HTMLLIElement" /> struct.</summary>
    public static unsafe partial class HTMLLIElementTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="HTMLLIElement" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(HTMLLIElement).GUID, Is.EqualTo(IID_HTMLLIElement));
        }

        /// <summary>Validates that the <see cref="HTMLLIElement" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HTMLLIElement>(), Is.EqualTo(sizeof(HTMLLIElement)));
        }

        /// <summary>Validates that the <see cref="HTMLLIElement" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HTMLLIElement).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HTMLLIElement" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(HTMLLIElement), Is.EqualTo(1));
        }
    }
}
