// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="HTMLAudioElement" /> struct.</summary>
    public static unsafe partial class HTMLAudioElementTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="HTMLAudioElement" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(HTMLAudioElement).GUID, Is.EqualTo(IID_HTMLAudioElement));
        }

        /// <summary>Validates that the <see cref="HTMLAudioElement" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<HTMLAudioElement>(), Is.EqualTo(sizeof(HTMLAudioElement)));
        }

        /// <summary>Validates that the <see cref="HTMLAudioElement" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(HTMLAudioElement).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="HTMLAudioElement" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(HTMLAudioElement), Is.EqualTo(1));
        }
    }
}
