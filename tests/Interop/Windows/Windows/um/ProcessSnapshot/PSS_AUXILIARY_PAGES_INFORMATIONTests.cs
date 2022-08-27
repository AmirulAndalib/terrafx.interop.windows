// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="PSS_AUXILIARY_PAGES_INFORMATION" /> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class PSS_AUXILIARY_PAGES_INFORMATIONTests
{
    /// <summary>Validates that the <see cref="PSS_AUXILIARY_PAGES_INFORMATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PSS_AUXILIARY_PAGES_INFORMATION>(), Is.EqualTo(sizeof(PSS_AUXILIARY_PAGES_INFORMATION)));
    }

    /// <summary>Validates that the <see cref="PSS_AUXILIARY_PAGES_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PSS_AUXILIARY_PAGES_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="PSS_AUXILIARY_PAGES_INFORMATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PSS_AUXILIARY_PAGES_INFORMATION), Is.EqualTo(4));
    }
}
