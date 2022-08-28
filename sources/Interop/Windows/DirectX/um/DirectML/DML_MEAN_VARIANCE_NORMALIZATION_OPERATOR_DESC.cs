// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC
{
    /// <include file='DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.ScaleTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* ScaleTensor;

    /// <include file='DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.BiasTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BiasTensor;

    /// <include file='DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.CrossChannel"]/*' />
    public BOOL CrossChannel;

    /// <include file='DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.NormalizeVariance"]/*' />
    public BOOL NormalizeVariance;

    /// <include file='DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.Epsilon"]/*' />
    public float Epsilon;

    /// <include file='DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.xml' path='doc/member[@name="DML_MEAN_VARIANCE_NORMALIZATION_OPERATOR_DESC.FusedActivation"]/*' />
    [NativeTypeName("const DML_OPERATOR_DESC *")]
    public DML_OPERATOR_DESC* FusedActivation;
}
