// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

namespace TerraFX.Interop.DirectX;

/// <include file='DxcDefine.xml' path='doc/member[@name="DxcDefine"]/*' />
public unsafe partial struct DxcDefine
{
    /// <include file='DxcDefine.xml' path='doc/member[@name="DxcDefine.Name"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* Name;

    /// <include file='DxcDefine.xml' path='doc/member[@name="DxcDefine.Value"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* Value;
}
