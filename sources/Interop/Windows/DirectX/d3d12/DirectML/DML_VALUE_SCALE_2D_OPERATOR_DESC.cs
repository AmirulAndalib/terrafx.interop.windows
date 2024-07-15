// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_VALUE_SCALE_2D_OPERATOR_DESC.xml' path='doc/member[@name="DML_VALUE_SCALE_2D_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_VALUE_SCALE_2D_OPERATOR_DESC
{
    /// <include file='DML_VALUE_SCALE_2D_OPERATOR_DESC.xml' path='doc/member[@name="DML_VALUE_SCALE_2D_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_VALUE_SCALE_2D_OPERATOR_DESC.xml' path='doc/member[@name="DML_VALUE_SCALE_2D_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_VALUE_SCALE_2D_OPERATOR_DESC.xml' path='doc/member[@name="DML_VALUE_SCALE_2D_OPERATOR_DESC.Scale"]/*' />
    public float Scale;

    /// <include file='DML_VALUE_SCALE_2D_OPERATOR_DESC.xml' path='doc/member[@name="DML_VALUE_SCALE_2D_OPERATOR_DESC.ChannelCount"]/*' />
    public uint ChannelCount;

    /// <include file='DML_VALUE_SCALE_2D_OPERATOR_DESC.xml' path='doc/member[@name="DML_VALUE_SCALE_2D_OPERATOR_DESC.Bias"]/*' />
    [NativeTypeName("const FLOAT *")]
    public float* Bias;
}
