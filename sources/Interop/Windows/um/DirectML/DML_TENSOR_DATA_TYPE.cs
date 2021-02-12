// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DML_TENSOR_DATA_TYPE
    {
        DML_TENSOR_DATA_TYPE_UNKNOWN,
        DML_TENSOR_DATA_TYPE_FLOAT32,
        DML_TENSOR_DATA_TYPE_FLOAT16,
        DML_TENSOR_DATA_TYPE_UINT32,
        DML_TENSOR_DATA_TYPE_UINT16,
        DML_TENSOR_DATA_TYPE_UINT8,
        DML_TENSOR_DATA_TYPE_INT32,
        DML_TENSOR_DATA_TYPE_INT16,
        DML_TENSOR_DATA_TYPE_INT8,
    }
}
