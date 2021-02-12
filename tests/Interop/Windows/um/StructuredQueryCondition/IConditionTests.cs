// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ICondition" /> struct.</summary>
    public static unsafe class IConditionTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ICondition" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ICondition).GUID, Is.EqualTo(IID_ICondition));
        }

        /// <summary>Validates that the <see cref="ICondition" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ICondition>(), Is.EqualTo(sizeof(ICondition)));
        }

        /// <summary>Validates that the <see cref="ICondition" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ICondition).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ICondition" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ICondition), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ICondition), Is.EqualTo(4));
            }
        }
    }
}
