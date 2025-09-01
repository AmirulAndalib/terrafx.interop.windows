// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.xml' path='doc/member[@name="D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION"]/*' />
public unsafe partial struct D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION
{
    /// <include file='D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.xml' path='doc/member[@name="D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.SubobjectToAssociate"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* SubobjectToAssociate;

    /// <include file='D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.xml' path='doc/member[@name="D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.NumExports"]/*' />
    public uint NumExports;

    /// <include file='D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.xml' path='doc/member[@name="D3D12_DXIL_SUBOBJECT_TO_EXPORTS_ASSOCIATION.pExports"]/*' />
    [NativeTypeName("LPCWSTR *")]
    public char** pExports;
}
