// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="KERB_PURGE_KDC_PROXY_CACHE_RESPONSE" /> struct.</summary>
public static unsafe partial class KERB_PURGE_KDC_PROXY_CACHE_RESPONSETests
{
    /// <summary>Validates that the <see cref="KERB_PURGE_KDC_PROXY_CACHE_RESPONSE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<KERB_PURGE_KDC_PROXY_CACHE_RESPONSE>(), Is.EqualTo(sizeof(KERB_PURGE_KDC_PROXY_CACHE_RESPONSE)));
    }

    /// <summary>Validates that the <see cref="KERB_PURGE_KDC_PROXY_CACHE_RESPONSE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KERB_PURGE_KDC_PROXY_CACHE_RESPONSE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="KERB_PURGE_KDC_PROXY_CACHE_RESPONSE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(KERB_PURGE_KDC_PROXY_CACHE_RESPONSE), Is.EqualTo(8));
    }
}
