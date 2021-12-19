// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="AppxBundleFactory" /> struct.</summary>
public static unsafe partial class AppxBundleFactoryTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="AppxBundleFactory" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(AppxBundleFactory).GUID, Is.EqualTo(IID_AppxBundleFactory));
    }

    /// <summary>Validates that the <see cref="AppxBundleFactory" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<AppxBundleFactory>(), Is.EqualTo(sizeof(AppxBundleFactory)));
    }

    /// <summary>Validates that the <see cref="AppxBundleFactory" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(AppxBundleFactory).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="AppxBundleFactory" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(AppxBundleFactory), Is.EqualTo(1));
    }
}
