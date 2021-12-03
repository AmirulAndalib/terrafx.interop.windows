// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DML_INTERMEDIATE_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INTERMEDIATE_GRAPH_EDGE_DESC"]/*' />
public unsafe partial struct DML_INTERMEDIATE_GRAPH_EDGE_DESC
{
    /// <include file='DML_INTERMEDIATE_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INTERMEDIATE_GRAPH_EDGE_DESC.FromNodeIndex"]/*' />
    public uint FromNodeIndex;

    /// <include file='DML_INTERMEDIATE_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INTERMEDIATE_GRAPH_EDGE_DESC.FromNodeOutputIndex"]/*' />
    public uint FromNodeOutputIndex;

    /// <include file='DML_INTERMEDIATE_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INTERMEDIATE_GRAPH_EDGE_DESC.ToNodeIndex"]/*' />
    public uint ToNodeIndex;

    /// <include file='DML_INTERMEDIATE_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INTERMEDIATE_GRAPH_EDGE_DESC.ToNodeInputIndex"]/*' />
    public uint ToNodeInputIndex;

    /// <include file='DML_INTERMEDIATE_GRAPH_EDGE_DESC.xml' path='doc/member[@name="DML_INTERMEDIATE_GRAPH_EDGE_DESC.Name"]/*' />
    [NativeTypeName("const char *")]
    public sbyte* Name;
}
