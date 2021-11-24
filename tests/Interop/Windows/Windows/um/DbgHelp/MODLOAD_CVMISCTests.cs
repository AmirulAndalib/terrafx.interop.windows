// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MODLOAD_CVMISC" /> struct.</summary>
public static unsafe partial class MODLOAD_CVMISCTests
{
    /// <summary>Validates that the <see cref="MODLOAD_CVMISC" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MODLOAD_CVMISC>(), Is.EqualTo(sizeof(MODLOAD_CVMISC)));
    }

    /// <summary>Validates that the <see cref="MODLOAD_CVMISC" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MODLOAD_CVMISC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MODLOAD_CVMISC" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MODLOAD_CVMISC), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(MODLOAD_CVMISC), Is.EqualTo(24));
        }
    }
}
