// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TRUSTED_PASSWORD_INFO" /> struct.</summary>
public static unsafe partial class TRUSTED_PASSWORD_INFOTests
{
    /// <summary>Validates that the <see cref="TRUSTED_PASSWORD_INFO" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TRUSTED_PASSWORD_INFO>(), Is.EqualTo(sizeof(TRUSTED_PASSWORD_INFO)));
    }

    /// <summary>Validates that the <see cref="TRUSTED_PASSWORD_INFO" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TRUSTED_PASSWORD_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TRUSTED_PASSWORD_INFO" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TRUSTED_PASSWORD_INFO), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(TRUSTED_PASSWORD_INFO), Is.EqualTo(16));
        }
    }
}
