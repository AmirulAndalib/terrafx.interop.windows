// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_TIMED_TEXT_ERROR_CODE
    {
        MF_TIMED_TEXT_ERROR_CODE_NOERROR = 0,
        MF_TIMED_TEXT_ERROR_CODE_FATAL = 1,
        MF_TIMED_TEXT_ERROR_CODE_DATA_FORMAT = 2,
        MF_TIMED_TEXT_ERROR_CODE_NETWORK = 3,
        MF_TIMED_TEXT_ERROR_CODE_INTERNAL = 4,
    }
}
