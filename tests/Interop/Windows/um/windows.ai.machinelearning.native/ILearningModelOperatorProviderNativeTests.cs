// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ILearningModelOperatorProviderNative" /> struct.</summary>
    public static unsafe class ILearningModelOperatorProviderNativeTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ILearningModelOperatorProviderNative" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ILearningModelOperatorProviderNative).GUID, Is.EqualTo(IID_ILearningModelOperatorProviderNative));
        }

        /// <summary>Validates that the <see cref="ILearningModelOperatorProviderNative" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ILearningModelOperatorProviderNative>(), Is.EqualTo(sizeof(ILearningModelOperatorProviderNative)));
        }

        /// <summary>Validates that the <see cref="ILearningModelOperatorProviderNative" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ILearningModelOperatorProviderNative).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ILearningModelOperatorProviderNative" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ILearningModelOperatorProviderNative), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ILearningModelOperatorProviderNative), Is.EqualTo(4));
            }
        }
    }
}
