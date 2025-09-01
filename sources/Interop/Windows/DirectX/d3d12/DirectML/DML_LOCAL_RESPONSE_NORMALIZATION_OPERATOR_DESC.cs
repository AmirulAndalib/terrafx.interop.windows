// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC
{
    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.CrossChannel"]/*' />
    public BOOL CrossChannel;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.LocalSize"]/*' />
    public uint LocalSize;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.Alpha"]/*' />
    public float Alpha;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.Beta"]/*' />
    public float Beta;

    /// <include file='DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_LOCAL_RESPONSE_NORMALIZATION_OPERATOR_DESC.Bias"]/*' />
    public float Bias;
}
