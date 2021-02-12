// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFT_OUTPUT_DATA_BUFFER_FLAGS
    {
        MFT_OUTPUT_DATA_BUFFER_INCOMPLETE = 0x1000000,
        MFT_OUTPUT_DATA_BUFFER_FORMAT_CHANGE = 0x100,
        MFT_OUTPUT_DATA_BUFFER_STREAM_END = 0x200,
        MFT_OUTPUT_DATA_BUFFER_NO_SAMPLE = 0x300,
    }
}
