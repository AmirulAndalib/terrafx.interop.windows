// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ApplicationDocumentLists.xml' path='doc/member[@name="ApplicationDocumentLists"]/*' />
[Guid("86BEC222-30F2-47E0-9F25-60D11CD75C28")]
public partial struct ApplicationDocumentLists : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_ApplicationDocumentLists;
}
