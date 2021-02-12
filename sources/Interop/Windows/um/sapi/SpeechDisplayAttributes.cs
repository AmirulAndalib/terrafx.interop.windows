// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.SPDISPLAYATTRIBUTES;

namespace TerraFX.Interop
{
    public enum SpeechDisplayAttributes
    {
        SDA_No_Trailing_Space = 0,
        SDA_One_Trailing_Space = SPAF_ONE_TRAILING_SPACE,
        SDA_Two_Trailing_Spaces = SPAF_TWO_TRAILING_SPACES,
        SDA_Consume_Leading_Spaces = SPAF_CONSUME_LEADING_SPACES,
    }
}
