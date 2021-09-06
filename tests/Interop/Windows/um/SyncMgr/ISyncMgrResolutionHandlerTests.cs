// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ISyncMgrResolutionHandler" /> struct.</summary>
    public static unsafe class ISyncMgrResolutionHandlerTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISyncMgrResolutionHandler" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ISyncMgrResolutionHandler).GUID, Is.EqualTo(IID_ISyncMgrResolutionHandler));
        }

        /// <summary>Validates that the <see cref="ISyncMgrResolutionHandler" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ISyncMgrResolutionHandler>(), Is.EqualTo(sizeof(ISyncMgrResolutionHandler)));
        }

        /// <summary>Validates that the <see cref="ISyncMgrResolutionHandler" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ISyncMgrResolutionHandler).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ISyncMgrResolutionHandler" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(ISyncMgrResolutionHandler), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(ISyncMgrResolutionHandler), Is.EqualTo(4));
            }
        }
    }
}
