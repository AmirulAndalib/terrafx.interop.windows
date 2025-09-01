// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_JOIN_OPERATOR_DESC.xml' path='doc/member[@name="DML_JOIN_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_JOIN_OPERATOR_DESC
{
    /// <include file='DML_JOIN_OPERATOR_DESC.xml' path='doc/member[@name="DML_JOIN_OPERATOR_DESC.InputCount"]/*' />
    public uint InputCount;

    /// <include file='DML_JOIN_OPERATOR_DESC.xml' path='doc/member[@name="DML_JOIN_OPERATOR_DESC.InputTensors"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensors;

    /// <include file='DML_JOIN_OPERATOR_DESC.xml' path='doc/member[@name="DML_JOIN_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_JOIN_OPERATOR_DESC.xml' path='doc/member[@name="DML_JOIN_OPERATOR_DESC.Axis"]/*' />
    public uint Axis;
}
