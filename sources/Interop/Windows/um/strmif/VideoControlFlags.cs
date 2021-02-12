// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum VideoControlFlags
    {
        VideoControlFlag_FlipHorizontal = 0x1,
        VideoControlFlag_FlipVertical = 0x2,
        VideoControlFlag_ExternalTriggerEnable = 0x4,
        VideoControlFlag_Trigger = 0x8,
    }
}
