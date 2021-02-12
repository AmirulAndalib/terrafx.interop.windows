// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMFContentDecryptionModule" /> struct.</summary>
    public static unsafe class IMFContentDecryptionModuleTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFContentDecryptionModule" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMFContentDecryptionModule).GUID, Is.EqualTo(IID_IMFContentDecryptionModule));
        }

        /// <summary>Validates that the <see cref="IMFContentDecryptionModule" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMFContentDecryptionModule>(), Is.EqualTo(sizeof(IMFContentDecryptionModule)));
        }

        /// <summary>Validates that the <see cref="IMFContentDecryptionModule" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMFContentDecryptionModule).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMFContentDecryptionModule" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMFContentDecryptionModule), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMFContentDecryptionModule), Is.EqualTo(4));
            }
        }
    }
}
