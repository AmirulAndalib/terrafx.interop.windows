// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="TF_SELECTIONSTYLE" /> struct.</summary>
    public static unsafe class TF_SELECTIONSTYLETests
    {
        /// <summary>Validates that the <see cref="TF_SELECTIONSTYLE" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<TF_SELECTIONSTYLE>(), Is.EqualTo(sizeof(TF_SELECTIONSTYLE)));
        }

        /// <summary>Validates that the <see cref="TF_SELECTIONSTYLE" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(TF_SELECTIONSTYLE).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="TF_SELECTIONSTYLE" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(TF_SELECTIONSTYLE), Is.EqualTo(8));
        }
    }
}
