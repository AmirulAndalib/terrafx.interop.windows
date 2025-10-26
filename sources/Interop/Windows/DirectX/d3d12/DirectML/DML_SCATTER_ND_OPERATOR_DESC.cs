// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_SCATTER_ND_OPERATOR_DESC.xml' path='doc/member[@name="DML_SCATTER_ND_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_SCATTER_ND_OPERATOR_DESC
{
    /// <include file='DML_SCATTER_ND_OPERATOR_DESC.xml' path='doc/member[@name="DML_SCATTER_ND_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_SCATTER_ND_OPERATOR_DESC.xml' path='doc/member[@name="DML_SCATTER_ND_OPERATOR_DESC.IndicesTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* IndicesTensor;

    /// <include file='DML_SCATTER_ND_OPERATOR_DESC.xml' path='doc/member[@name="DML_SCATTER_ND_OPERATOR_DESC.UpdatesTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* UpdatesTensor;

    /// <include file='DML_SCATTER_ND_OPERATOR_DESC.xml' path='doc/member[@name="DML_SCATTER_ND_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_SCATTER_ND_OPERATOR_DESC.xml' path='doc/member[@name="DML_SCATTER_ND_OPERATOR_DESC.InputDimensionCount"]/*' />
    public uint InputDimensionCount;

    /// <include file='DML_SCATTER_ND_OPERATOR_DESC.xml' path='doc/member[@name="DML_SCATTER_ND_OPERATOR_DESC.IndicesDimensionCount"]/*' />
    public uint IndicesDimensionCount;
}
