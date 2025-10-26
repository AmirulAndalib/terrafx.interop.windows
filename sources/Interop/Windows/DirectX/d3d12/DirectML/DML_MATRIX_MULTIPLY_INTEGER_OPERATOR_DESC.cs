// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC
{
    /// <include file='DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC.ATensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* ATensor;

    /// <include file='DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC.AZeroPointTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* AZeroPointTensor;

    /// <include file='DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC.BTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BTensor;

    /// <include file='DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC.BZeroPointTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BZeroPointTensor;

    /// <include file='DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC.xml' path='doc/member[@name="DML_MATRIX_MULTIPLY_INTEGER_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;
}
