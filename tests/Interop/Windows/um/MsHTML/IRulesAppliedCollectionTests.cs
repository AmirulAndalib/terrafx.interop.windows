// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IRulesAppliedCollection" /> struct.</summary>
    public static unsafe partial class IRulesAppliedCollectionTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IRulesAppliedCollection" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IRulesAppliedCollection).GUID, Is.EqualTo(IID_IRulesAppliedCollection));
        }

        /// <summary>Validates that the <see cref="IRulesAppliedCollection" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IRulesAppliedCollection>(), Is.EqualTo(sizeof(IRulesAppliedCollection)));
        }

        /// <summary>Validates that the <see cref="IRulesAppliedCollection" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IRulesAppliedCollection).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IRulesAppliedCollection" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IRulesAppliedCollection), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IRulesAppliedCollection), Is.EqualTo(4));
            }
        }
    }
}
