// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_STREAM_STATE
    {
        MF_STREAM_STATE_STOPPED = 0,
        MF_STREAM_STATE_PAUSED = (MF_STREAM_STATE_STOPPED + 1),
        MF_STREAM_STATE_RUNNING = (MF_STREAM_STATE_PAUSED + 1),
    }
}
