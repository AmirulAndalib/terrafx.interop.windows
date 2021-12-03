// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='DML_MAX_POOLING2_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING2_OPERATOR_DESC"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public unsafe partial struct DML_MAX_POOLING2_OPERATOR_DESC
{
    /// <include file='DML_MAX_POOLING2_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING2_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_MAX_POOLING2_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING2_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_MAX_POOLING2_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING2_OPERATOR_DESC.OutputIndicesTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputIndicesTensor;

    /// <include file='DML_MAX_POOLING2_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING2_OPERATOR_DESC.DimensionCount"]/*' />
    public uint DimensionCount;

    /// <include file='DML_MAX_POOLING2_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING2_OPERATOR_DESC.Strides"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* Strides;

    /// <include file='DML_MAX_POOLING2_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING2_OPERATOR_DESC.WindowSize"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* WindowSize;

    /// <include file='DML_MAX_POOLING2_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING2_OPERATOR_DESC.StartPadding"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* StartPadding;

    /// <include file='DML_MAX_POOLING2_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING2_OPERATOR_DESC.EndPadding"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* EndPadding;

    /// <include file='DML_MAX_POOLING2_OPERATOR_DESC.xml' path='doc/member[@name="DML_MAX_POOLING2_OPERATOR_DESC.Dilations"]/*' />
    [NativeTypeName("const UINT *")]
    public uint* Dilations;
}
