// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='OldHTMLFormElement.xml' path='doc/member[@name="OldHTMLFormElement"]/*' />
[Guid("0D04D285-6BEC-11CF-8B97-00AA00476DA6")]
public unsafe partial struct OldHTMLFormElement : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_OldHTMLFormElement);
}
