// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMLOperatorShapeInferrer" /> struct.</summary>
    public static unsafe class IMLOperatorShapeInferrerTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMLOperatorShapeInferrer" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMLOperatorShapeInferrer).GUID, Is.EqualTo(IID_IMLOperatorShapeInferrer));
        }

        /// <summary>Validates that the <see cref="IMLOperatorShapeInferrer" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMLOperatorShapeInferrer>(), Is.EqualTo(sizeof(IMLOperatorShapeInferrer)));
        }

        /// <summary>Validates that the <see cref="IMLOperatorShapeInferrer" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMLOperatorShapeInferrer).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMLOperatorShapeInferrer" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMLOperatorShapeInferrer), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMLOperatorShapeInferrer), Is.EqualTo(4));
            }
        }
    }
}
