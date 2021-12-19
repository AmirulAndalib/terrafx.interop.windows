// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SOCKADDR" /> struct.</summary>
public static unsafe partial class SOCKADDRTests
{
    /// <summary>Validates that the <see cref="SOCKADDR" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SOCKADDR>(), Is.EqualTo(sizeof(SOCKADDR)));
    }

    /// <summary>Validates that the <see cref="SOCKADDR" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SOCKADDR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SOCKADDR" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SOCKADDR), Is.EqualTo(16));
    }
}
