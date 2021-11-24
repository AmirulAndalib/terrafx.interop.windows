// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IApplicationDesignModeSettings" /> struct.</summary>
public static unsafe partial class IApplicationDesignModeSettingsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IApplicationDesignModeSettings" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IApplicationDesignModeSettings).GUID, Is.EqualTo(IID_IApplicationDesignModeSettings));
    }

    /// <summary>Validates that the <see cref="IApplicationDesignModeSettings" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IApplicationDesignModeSettings>(), Is.EqualTo(sizeof(IApplicationDesignModeSettings)));
    }

    /// <summary>Validates that the <see cref="IApplicationDesignModeSettings" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IApplicationDesignModeSettings).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IApplicationDesignModeSettings" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IApplicationDesignModeSettings), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IApplicationDesignModeSettings), Is.EqualTo(4));
        }
    }
}
