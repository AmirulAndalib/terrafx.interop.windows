// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ACTRL_ACCESSA" /> struct.</summary>
public static unsafe partial class ACTRL_ACCESSATests
{
    /// <summary>Validates that the <see cref="ACTRL_ACCESSA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ACTRL_ACCESSA>(), Is.EqualTo(sizeof(ACTRL_ACCESSA)));
    }

    /// <summary>Validates that the <see cref="ACTRL_ACCESSA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ACTRL_ACCESSA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ACTRL_ACCESSA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ACTRL_ACCESSA), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(ACTRL_ACCESSA), Is.EqualTo(8));
        }
    }
}
