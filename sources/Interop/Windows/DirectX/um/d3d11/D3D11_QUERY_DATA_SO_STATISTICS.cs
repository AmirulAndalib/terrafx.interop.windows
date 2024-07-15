// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_QUERY_DATA_SO_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_SO_STATISTICS"]/*' />
public partial struct D3D11_QUERY_DATA_SO_STATISTICS
{
    /// <include file='D3D11_QUERY_DATA_SO_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_SO_STATISTICS.NumPrimitivesWritten"]/*' />
    [NativeTypeName("UINT64")]
    public ulong NumPrimitivesWritten;

    /// <include file='D3D11_QUERY_DATA_SO_STATISTICS.xml' path='doc/member[@name="D3D11_QUERY_DATA_SO_STATISTICS.PrimitivesStorageNeeded"]/*' />
    [NativeTypeName("UINT64")]
    public ulong PrimitivesStorageNeeded;
}
