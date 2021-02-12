// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.SPRULESTATE;

namespace TerraFX.Interop
{
    public enum SpeechRuleState
    {
        SGDSInactive = SPRS_INACTIVE,
        SGDSActive = SPRS_ACTIVE,
        SGDSActiveWithAutoPause = SPRS_ACTIVE_WITH_AUTO_PAUSE,
        SGDSActiveUserDelimited = SPRS_ACTIVE_USER_DELIMITED,
    }
}
