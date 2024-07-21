// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_ROI_ALIGN1_OPERATOR_DESC
{
    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.ROITensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* ROITensor;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.BatchIndicesTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BatchIndicesTensor;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.ReductionFunction"]/*' />
    public DML_REDUCE_FUNCTION ReductionFunction;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.InterpolationMode"]/*' />
    public DML_INTERPOLATION_MODE InterpolationMode;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.SpatialScaleX"]/*' />
    public float SpatialScaleX;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.SpatialScaleY"]/*' />
    public float SpatialScaleY;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.InputPixelOffset"]/*' />
    public float InputPixelOffset;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.OutputPixelOffset"]/*' />
    public float OutputPixelOffset;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.OutOfBoundsInputValue"]/*' />
    public float OutOfBoundsInputValue;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.MinimumSamplesPerOutput"]/*' />
    public uint MinimumSamplesPerOutput;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.MaximumSamplesPerOutput"]/*' />
    public uint MaximumSamplesPerOutput;

    /// <include file='DML_ROI_ALIGN1_OPERATOR_DESC.xml' path='doc/member[@name="DML_ROI_ALIGN1_OPERATOR_DESC.AlignRegionsToCorners"]/*' />
    public BOOL AlignRegionsToCorners;
}
