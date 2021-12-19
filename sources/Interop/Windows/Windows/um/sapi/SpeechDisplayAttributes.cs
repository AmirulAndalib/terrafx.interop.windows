// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SPDISPLAYATTRIBUTES;

namespace TerraFX.Interop.Windows;

/// <include file='SpeechDisplayAttributes.xml' path='doc/member[@name="SpeechDisplayAttributes"]/*' />
public enum SpeechDisplayAttributes
{
    /// <include file='SpeechDisplayAttributes.xml' path='doc/member[@name="SpeechDisplayAttributes.SDA_No_Trailing_Space"]/*' />
    SDA_No_Trailing_Space = 0,

    /// <include file='SpeechDisplayAttributes.xml' path='doc/member[@name="SpeechDisplayAttributes.SDA_One_Trailing_Space"]/*' />
    SDA_One_Trailing_Space = SPAF_ONE_TRAILING_SPACE,

    /// <include file='SpeechDisplayAttributes.xml' path='doc/member[@name="SpeechDisplayAttributes.SDA_Two_Trailing_Spaces"]/*' />
    SDA_Two_Trailing_Spaces = SPAF_TWO_TRAILING_SPACES,

    /// <include file='SpeechDisplayAttributes.xml' path='doc/member[@name="SpeechDisplayAttributes.SDA_Consume_Leading_Spaces"]/*' />
    SDA_Consume_Leading_Spaces = SPAF_CONSUME_LEADING_SPACES,
}
