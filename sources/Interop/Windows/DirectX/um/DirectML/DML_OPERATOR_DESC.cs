// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DML_OPERATOR_DESC.xml' path='doc/member[@name="DML_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_OPERATOR_DESC
{
    /// <include file='DML_OPERATOR_DESC.xml' path='doc/member[@name="DML_OPERATOR_DESC.Type"]/*' />
    public DML_OPERATOR_TYPE Type;

    /// <include file='DML_OPERATOR_DESC.xml' path='doc/member[@name="DML_OPERATOR_DESC.Desc"]/*' />
    [NativeTypeName("const void *")]
    public void* Desc;
}
