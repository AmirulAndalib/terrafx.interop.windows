// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='RulesAppliedCollection.xml' path='doc/member[@name="RulesAppliedCollection"]/*' />
[Guid("671926EE-C3CF-40AF-BE8F-1CBAEE6486E8")]
public unsafe partial struct RulesAppliedCollection : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_RulesAppliedCollection));
}
