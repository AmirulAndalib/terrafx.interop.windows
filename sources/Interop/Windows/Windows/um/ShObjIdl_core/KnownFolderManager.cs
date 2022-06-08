// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='KnownFolderManager.xml' path='doc/member[@name="KnownFolderManager"]/*' />
[Guid("4DF0C730-DF9D-4AE3-9153-AA6B82E9795A")]
public partial struct KnownFolderManager : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_KnownFolderManager;
}
