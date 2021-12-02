// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="KERB_QUERY_S4U2PROXY_CACHE_RESPONSE" /> struct.</summary>
public static unsafe partial class KERB_QUERY_S4U2PROXY_CACHE_RESPONSETests
{
    /// <summary>Validates that the <see cref="KERB_QUERY_S4U2PROXY_CACHE_RESPONSE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<KERB_QUERY_S4U2PROXY_CACHE_RESPONSE>(), Is.EqualTo(sizeof(KERB_QUERY_S4U2PROXY_CACHE_RESPONSE)));
    }

    /// <summary>Validates that the <see cref="KERB_QUERY_S4U2PROXY_CACHE_RESPONSE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(KERB_QUERY_S4U2PROXY_CACHE_RESPONSE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="KERB_QUERY_S4U2PROXY_CACHE_RESPONSE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(KERB_QUERY_S4U2PROXY_CACHE_RESPONSE), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(KERB_QUERY_S4U2PROXY_CACHE_RESPONSE), Is.EqualTo(12));
        }
    }
}
