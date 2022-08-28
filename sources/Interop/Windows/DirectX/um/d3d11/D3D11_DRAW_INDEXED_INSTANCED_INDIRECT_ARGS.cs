// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS.xml' path='doc/member[@name="D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS"]/*' />
public partial struct D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS
{
    /// <include file='D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS.xml' path='doc/member[@name="D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS.IndexCountPerInstance"]/*' />
    public uint IndexCountPerInstance;

    /// <include file='D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS.xml' path='doc/member[@name="D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS.InstanceCount"]/*' />
    public uint InstanceCount;

    /// <include file='D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS.xml' path='doc/member[@name="D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS.StartIndexLocation"]/*' />
    public uint StartIndexLocation;

    /// <include file='D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS.xml' path='doc/member[@name="D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS.BaseVertexLocation"]/*' />
    public int BaseVertexLocation;

    /// <include file='D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS.xml' path='doc/member[@name="D3D11_DRAW_INDEXED_INSTANCED_INDIRECT_ARGS.StartInstanceLocation"]/*' />
    public uint StartInstanceLocation;
}
