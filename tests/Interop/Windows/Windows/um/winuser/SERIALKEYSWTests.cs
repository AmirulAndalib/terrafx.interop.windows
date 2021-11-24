// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SERIALKEYSW" /> struct.</summary>
public static unsafe partial class SERIALKEYSWTests
{
    /// <summary>Validates that the <see cref="SERIALKEYSW" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SERIALKEYSW>(), Is.EqualTo(sizeof(SERIALKEYSW)));
    }

    /// <summary>Validates that the <see cref="SERIALKEYSW" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SERIALKEYSW).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SERIALKEYSW" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SERIALKEYSW), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(SERIALKEYSW), Is.EqualTo(28));
        }
    }
}
