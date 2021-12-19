// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IAudioEffectsChangedNotificationClient" /> struct.</summary>
[SupportedOSPlatform("windows10.0.22000.0")]
public static unsafe partial class IAudioEffectsChangedNotificationClientTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAudioEffectsChangedNotificationClient" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAudioEffectsChangedNotificationClient).GUID, Is.EqualTo(IID_IAudioEffectsChangedNotificationClient));
    }

    /// <summary>Validates that the <see cref="IAudioEffectsChangedNotificationClient" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAudioEffectsChangedNotificationClient>(), Is.EqualTo(sizeof(IAudioEffectsChangedNotificationClient)));
    }

    /// <summary>Validates that the <see cref="IAudioEffectsChangedNotificationClient" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAudioEffectsChangedNotificationClient).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IAudioEffectsChangedNotificationClient" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAudioEffectsChangedNotificationClient), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAudioEffectsChangedNotificationClient), Is.EqualTo(4));
        }
    }
}