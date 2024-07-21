// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MsftDiscFormat2Erase" /> struct.</summary>
public static unsafe partial class MsftDiscFormat2EraseTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="MsftDiscFormat2Erase" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(MsftDiscFormat2Erase).GUID, Is.EqualTo(CLSID_MsftDiscFormat2Erase));
    }
}
