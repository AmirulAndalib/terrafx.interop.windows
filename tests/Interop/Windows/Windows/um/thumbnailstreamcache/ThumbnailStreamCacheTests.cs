// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbnailstreamcache.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.Windows;

namespace TerraFX.Interop.Windows.UnitTests
{
    /// <summary>Provides validation of the <see cref="ThumbnailStreamCache" /> struct.</summary>
    public static unsafe partial class ThumbnailStreamCacheTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ThumbnailStreamCache" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(ThumbnailStreamCache).GUID, Is.EqualTo(IID_ThumbnailStreamCache));
        }

        /// <summary>Validates that the <see cref="ThumbnailStreamCache" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ThumbnailStreamCache>(), Is.EqualTo(sizeof(ThumbnailStreamCache)));
        }

        /// <summary>Validates that the <see cref="ThumbnailStreamCache" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ThumbnailStreamCache).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ThumbnailStreamCache" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(ThumbnailStreamCache), Is.EqualTo(1));
        }
    }
}
