// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winternl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="PUBLIC_OBJECT_TYPE_INFORMATION" /> struct.</summary>
public static unsafe partial class PUBLIC_OBJECT_TYPE_INFORMATIONTests
{
    /// <summary>Validates that the <see cref="PUBLIC_OBJECT_TYPE_INFORMATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PUBLIC_OBJECT_TYPE_INFORMATION>(), Is.EqualTo(sizeof(PUBLIC_OBJECT_TYPE_INFORMATION)));
    }

    /// <summary>Validates that the <see cref="PUBLIC_OBJECT_TYPE_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PUBLIC_OBJECT_TYPE_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="PUBLIC_OBJECT_TYPE_INFORMATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(PUBLIC_OBJECT_TYPE_INFORMATION), Is.EqualTo(104));
        }
        else
        {
            Assert.That(sizeof(PUBLIC_OBJECT_TYPE_INFORMATION), Is.EqualTo(96));
        }
    }
}
