// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='SuspensionDependencyManager.xml' path='doc/member[@name="SuspensionDependencyManager"]/*' />
[Guid("6B273FC5-61FD-4918-95A2-C3B5E9D7F581")]
public partial struct SuspensionDependencyManager : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_SuspensionDependencyManager;
}
