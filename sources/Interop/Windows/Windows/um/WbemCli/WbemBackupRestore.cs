// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='WbemBackupRestore.xml' path='doc/member[@name="WbemBackupRestore"]/*' />
[Guid("C49E32C6-BC8B-11D2-85D4-00105A1F8304")]
public partial struct WbemBackupRestore : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_WbemBackupRestore;
}
