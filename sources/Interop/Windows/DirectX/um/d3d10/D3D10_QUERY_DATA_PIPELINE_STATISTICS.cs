// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D10_QUERY_DATA_PIPELINE_STATISTICS"]/*' />
public partial struct D3D10_QUERY_DATA_PIPELINE_STATISTICS
{
    /// <include file='D3D10_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D10_QUERY_DATA_PIPELINE_STATISTICS.IAVertices"]/*' />
    [NativeTypeName("UINT64")]
    public ulong IAVertices;

    /// <include file='D3D10_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D10_QUERY_DATA_PIPELINE_STATISTICS.IAPrimitives"]/*' />
    [NativeTypeName("UINT64")]
    public ulong IAPrimitives;

    /// <include file='D3D10_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D10_QUERY_DATA_PIPELINE_STATISTICS.VSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong VSInvocations;

    /// <include file='D3D10_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D10_QUERY_DATA_PIPELINE_STATISTICS.GSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong GSInvocations;

    /// <include file='D3D10_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D10_QUERY_DATA_PIPELINE_STATISTICS.GSPrimitives"]/*' />
    [NativeTypeName("UINT64")]
    public ulong GSPrimitives;

    /// <include file='D3D10_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D10_QUERY_DATA_PIPELINE_STATISTICS.CInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CInvocations;

    /// <include file='D3D10_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D10_QUERY_DATA_PIPELINE_STATISTICS.CPrimitives"]/*' />
    [NativeTypeName("UINT64")]
    public ulong CPrimitives;

    /// <include file='D3D10_QUERY_DATA_PIPELINE_STATISTICS.xml' path='doc/member[@name="D3D10_QUERY_DATA_PIPELINE_STATISTICS.PSInvocations"]/*' />
    [NativeTypeName("UINT64")]
    public ulong PSInvocations;
}
