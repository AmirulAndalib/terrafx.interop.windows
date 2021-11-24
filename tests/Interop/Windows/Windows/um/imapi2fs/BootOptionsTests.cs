// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="BootOptions" /> struct.</summary>
public static unsafe partial class BootOptionsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="BootOptions" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(BootOptions).GUID, Is.EqualTo(CLSID_BootOptions));
    }

    /// <summary>Validates that the <see cref="BootOptions" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BootOptions>(), Is.EqualTo(sizeof(BootOptions)));
    }

    /// <summary>Validates that the <see cref="BootOptions" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BootOptions).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="BootOptions" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BootOptions), Is.EqualTo(1));
    }
}
