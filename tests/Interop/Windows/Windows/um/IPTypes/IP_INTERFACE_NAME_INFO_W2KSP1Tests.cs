// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/IPTypes.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IP_INTERFACE_NAME_INFO_W2KSP1" /> struct.</summary>
public static unsafe partial class IP_INTERFACE_NAME_INFO_W2KSP1Tests
{
    /// <summary>Validates that the <see cref="IP_INTERFACE_NAME_INFO_W2KSP1" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IP_INTERFACE_NAME_INFO_W2KSP1>(), Is.EqualTo(sizeof(IP_INTERFACE_NAME_INFO_W2KSP1)));
    }

    /// <summary>Validates that the <see cref="IP_INTERFACE_NAME_INFO_W2KSP1" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IP_INTERFACE_NAME_INFO_W2KSP1).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IP_INTERFACE_NAME_INFO_W2KSP1" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(IP_INTERFACE_NAME_INFO_W2KSP1), Is.EqualTo(44));
    }
}
