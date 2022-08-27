// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IApartmentShutdown" /> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IApartmentShutdownTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IApartmentShutdown" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IApartmentShutdown).GUID, Is.EqualTo(IID_IApartmentShutdown));
    }

    /// <summary>Validates that the <see cref="IApartmentShutdown" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IApartmentShutdown>(), Is.EqualTo(sizeof(IApartmentShutdown)));
    }

    /// <summary>Validates that the <see cref="IApartmentShutdown" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IApartmentShutdown).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IApartmentShutdown" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IApartmentShutdown), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IApartmentShutdown), Is.EqualTo(4));
        }
    }
}
