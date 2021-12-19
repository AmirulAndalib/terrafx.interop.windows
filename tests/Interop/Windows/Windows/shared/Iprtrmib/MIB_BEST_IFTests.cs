// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MIB_BEST_IF" /> struct.</summary>
public static unsafe partial class MIB_BEST_IFTests
{
    /// <summary>Validates that the <see cref="MIB_BEST_IF" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIB_BEST_IF>(), Is.EqualTo(sizeof(MIB_BEST_IF)));
    }

    /// <summary>Validates that the <see cref="MIB_BEST_IF" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIB_BEST_IF).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MIB_BEST_IF" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MIB_BEST_IF), Is.EqualTo(8));
    }
}
