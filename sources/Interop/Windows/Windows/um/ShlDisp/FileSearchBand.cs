// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='FileSearchBand.xml' path='doc/member[@name="FileSearchBand"]/*' />
[Guid("C4EE31F3-4768-11D2-BE5C-00A0C9A83DA1")]
public partial struct FileSearchBand : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_FileSearchBand;
}
