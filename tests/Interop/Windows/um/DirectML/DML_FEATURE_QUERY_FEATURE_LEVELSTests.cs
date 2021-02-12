// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="DML_FEATURE_QUERY_FEATURE_LEVELS" /> struct.</summary>
    public static unsafe class DML_FEATURE_QUERY_FEATURE_LEVELSTests
    {
        /// <summary>Validates that the <see cref="DML_FEATURE_QUERY_FEATURE_LEVELS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<DML_FEATURE_QUERY_FEATURE_LEVELS>(), Is.EqualTo(sizeof(DML_FEATURE_QUERY_FEATURE_LEVELS)));
        }

        /// <summary>Validates that the <see cref="DML_FEATURE_QUERY_FEATURE_LEVELS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(DML_FEATURE_QUERY_FEATURE_LEVELS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="DML_FEATURE_QUERY_FEATURE_LEVELS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(DML_FEATURE_QUERY_FEATURE_LEVELS), Is.EqualTo(16));
            }
            else
            {
                Assert.That(sizeof(DML_FEATURE_QUERY_FEATURE_LEVELS), Is.EqualTo(8));
            }
        }
    }
}
