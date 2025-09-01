// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ApplicationDesignModeSettings.xml' path='doc/member[@name="ApplicationDesignModeSettings"]/*' />
[Guid("958A6FB5-DCB2-4FAF-AAFD-7FB054AD1A3B")]
public unsafe partial struct ApplicationDesignModeSettings : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ApplicationDesignModeSettings);
}
