// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from D3D12Downlevel in the https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7 nuget package, version 1.1.0
// Original source is Copyright © Microsoft. All rights reserved. License details can be found here: https://www.nuget.org/packages/Microsoft.Direct3D.D3D12On7/1.1.0/License

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="ID3D12CommandQueueDownlevel" /> struct.</summary>
public static unsafe partial class ID3D12CommandQueueDownlevelTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12CommandQueueDownlevel" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3D12CommandQueueDownlevel).GUID, Is.EqualTo(IID_ID3D12CommandQueueDownlevel));
    }
}
