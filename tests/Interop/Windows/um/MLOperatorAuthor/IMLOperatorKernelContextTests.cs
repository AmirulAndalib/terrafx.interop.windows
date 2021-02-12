// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMLOperatorKernelContext" /> struct.</summary>
    public static unsafe class IMLOperatorKernelContextTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMLOperatorKernelContext" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMLOperatorKernelContext).GUID, Is.EqualTo(IID_IMLOperatorKernelContext));
        }

        /// <summary>Validates that the <see cref="IMLOperatorKernelContext" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMLOperatorKernelContext>(), Is.EqualTo(sizeof(IMLOperatorKernelContext)));
        }

        /// <summary>Validates that the <see cref="IMLOperatorKernelContext" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMLOperatorKernelContext).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMLOperatorKernelContext" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMLOperatorKernelContext), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMLOperatorKernelContext), Is.EqualTo(4));
            }
        }
    }
}
