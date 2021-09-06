// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISyncMgrConflictResolveInfo" /> struct.</summary>
    public static unsafe class ISyncMgrConflictResolveInfoTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISyncMgrConflictResolveInfo" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISyncMgrConflictResolveInfo).GUID, Is.EqualTo(IID_ISyncMgrConflictResolveInfo));
        }

        /// <summary>Validates that the <see cref="ISyncMgrConflictResolveInfo" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISyncMgrConflictResolveInfo>(), Is.EqualTo(sizeof(ISyncMgrConflictResolveInfo)));
        }

        /// <summary>Validates that the <see cref="ISyncMgrConflictResolveInfo" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISyncMgrConflictResolveInfo).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISyncMgrConflictResolveInfo" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISyncMgrConflictResolveInfo), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISyncMgrConflictResolveInfo), Is.EqualTo(4));
            }
        }
    }
}
