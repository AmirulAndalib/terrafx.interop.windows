// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFP_CREATION_OPTIONS
    {
        MFP_OPTION_NONE = 0,
        MFP_OPTION_FREE_THREADED_CALLBACK = 0x1,
        MFP_OPTION_NO_MMCSS = 0x2,
        MFP_OPTION_NO_REMOTE_DESKTOP_OPTIMIZATION = 0x4,
    }
}
