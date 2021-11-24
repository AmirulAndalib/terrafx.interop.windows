// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IExtensionServices" /> struct.</summary>
public static unsafe partial class IExtensionServicesTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IExtensionServices" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IExtensionServices).GUID, Is.EqualTo(IID_IExtensionServices));
    }

    /// <summary>Validates that the <see cref="IExtensionServices" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IExtensionServices>(), Is.EqualTo(sizeof(IExtensionServices)));
    }

    /// <summary>Validates that the <see cref="IExtensionServices" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IExtensionServices).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IExtensionServices" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IExtensionServices), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IExtensionServices), Is.EqualTo(4));
        }
    }
}
