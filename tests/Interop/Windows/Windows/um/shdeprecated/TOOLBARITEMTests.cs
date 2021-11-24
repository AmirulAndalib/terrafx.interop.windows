// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TOOLBARITEM" /> struct.</summary>
public static unsafe partial class TOOLBARITEMTests
{
    /// <summary>Validates that the <see cref="TOOLBARITEM" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TOOLBARITEM>(), Is.EqualTo(sizeof(TOOLBARITEM)));
    }

    /// <summary>Validates that the <see cref="TOOLBARITEM" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TOOLBARITEM).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TOOLBARITEM" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TOOLBARITEM), Is.EqualTo(48));
        }
        else
        {
            Assert.That(sizeof(TOOLBARITEM), Is.EqualTo(32));
        }
    }
}
