// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='SpCompressedLexicon.xml' path='doc/member[@name="SpCompressedLexicon"]/*' />
[Guid("90903716-2F42-11D3-9C26-00C04F8EF87C")]
public partial struct SpCompressedLexicon : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_SpCompressedLexicon;
}
