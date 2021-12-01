// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='SHDESCRIPTIONID.xml' path='doc/member[@name="SHDESCRIPTIONID"]/*' />
public partial struct SHDESCRIPTIONID
{
    /// <include file='SHDESCRIPTIONID.xml' path='doc/member[@name="SHDESCRIPTIONID.dwDescriptionId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwDescriptionId;

    /// <include file='SHDESCRIPTIONID.xml' path='doc/member[@name="SHDESCRIPTIONID.clsid"]/*' />
    [NativeTypeName("CLSID")]
    public Guid clsid;
}
