// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum DML_REDUCE_FUNCTION
    {
        DML_REDUCE_FUNCTION_ARGMAX,
        DML_REDUCE_FUNCTION_ARGMIN,
        DML_REDUCE_FUNCTION_AVERAGE,
        DML_REDUCE_FUNCTION_L1,
        DML_REDUCE_FUNCTION_L2,
        DML_REDUCE_FUNCTION_LOG_SUM,
        DML_REDUCE_FUNCTION_LOG_SUM_EXP,
        DML_REDUCE_FUNCTION_MAX,
        DML_REDUCE_FUNCTION_MIN,
        DML_REDUCE_FUNCTION_MULTIPLY,
        DML_REDUCE_FUNCTION_SUM,
        DML_REDUCE_FUNCTION_SUM_SQUARE,
    }
}
