// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DML_CUMULATIVE_PRODUCT_OPERATOR_DESC.xml' path='doc/member[@name="DML_CUMULATIVE_PRODUCT_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_CUMULATIVE_PRODUCT_OPERATOR_DESC
{
    /// <include file='DML_CUMULATIVE_PRODUCT_OPERATOR_DESC.xml' path='doc/member[@name="DML_CUMULATIVE_PRODUCT_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_CUMULATIVE_PRODUCT_OPERATOR_DESC.xml' path='doc/member[@name="DML_CUMULATIVE_PRODUCT_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_CUMULATIVE_PRODUCT_OPERATOR_DESC.xml' path='doc/member[@name="DML_CUMULATIVE_PRODUCT_OPERATOR_DESC.Axis"]/*' />
    public uint Axis;

    /// <include file='DML_CUMULATIVE_PRODUCT_OPERATOR_DESC.xml' path='doc/member[@name="DML_CUMULATIVE_PRODUCT_OPERATOR_DESC.AxisDirection"]/*' />
    public DML_AXIS_DIRECTION AxisDirection;

    /// <include file='DML_CUMULATIVE_PRODUCT_OPERATOR_DESC.xml' path='doc/member[@name="DML_CUMULATIVE_PRODUCT_OPERATOR_DESC.HasExclusiveProduct"]/*' />
    public BOOL HasExclusiveProduct;
}
