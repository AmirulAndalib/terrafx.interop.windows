// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/iphlpapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="INTERFACE_HARDWARE_CROSSTIMESTAMP" /> struct.</summary>
[SupportedOSPlatform("windows10.0.22000.0")]
public static unsafe partial class INTERFACE_HARDWARE_CROSSTIMESTAMPTests
{
    /// <summary>Validates that the <see cref="INTERFACE_HARDWARE_CROSSTIMESTAMP" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<INTERFACE_HARDWARE_CROSSTIMESTAMP>(), Is.EqualTo(sizeof(INTERFACE_HARDWARE_CROSSTIMESTAMP)));
    }

    /// <summary>Validates that the <see cref="INTERFACE_HARDWARE_CROSSTIMESTAMP" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(INTERFACE_HARDWARE_CROSSTIMESTAMP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="INTERFACE_HARDWARE_CROSSTIMESTAMP" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(INTERFACE_HARDWARE_CROSSTIMESTAMP), Is.EqualTo(24));
    }
}
