// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.616.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_LSTM_OPERATOR_DESC
{
    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.WeightTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* WeightTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.RecurrenceTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* RecurrenceTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.BiasTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* BiasTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.HiddenInitTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* HiddenInitTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.CellMemInitTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* CellMemInitTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.SequenceLengthsTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* SequenceLengthsTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.PeepholeTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* PeepholeTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.OutputSequenceTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputSequenceTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.OutputSingleTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputSingleTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.OutputCellSingleTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputCellSingleTensor;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.ActivationDescCount"]/*' />
    public uint ActivationDescCount;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.ActivationDescs"]/*' />
    [NativeTypeName("const DML_OPERATOR_DESC *")]
    public DML_OPERATOR_DESC* ActivationDescs;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.Direction"]/*' />
    public DML_RECURRENT_NETWORK_DIRECTION Direction;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.ClipThreshold"]/*' />
    public float ClipThreshold;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.UseClipThreshold"]/*' />
    public BOOL UseClipThreshold;

    /// <include file='DML_LSTM_OPERATOR_DESC.xml' path='doc/member[@name="DML_LSTM_OPERATOR_DESC.CoupleInputForget"]/*' />
    public BOOL CoupleInputForget;
}
