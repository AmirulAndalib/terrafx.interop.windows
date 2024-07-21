// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SPVPRIORITY;

namespace TerraFX.Interop.Windows;

/// <include file='SpeechVoicePriority.xml' path='doc/member[@name="SpeechVoicePriority"]/*' />
public enum SpeechVoicePriority
{
    /// <include file='SpeechVoicePriority.xml' path='doc/member[@name="SpeechVoicePriority.SVPNormal"]/*' />
    SVPNormal = SPVPRI_NORMAL,

    /// <include file='SpeechVoicePriority.xml' path='doc/member[@name="SpeechVoicePriority.SVPAlert"]/*' />
    SVPAlert = SPVPRI_ALERT,

    /// <include file='SpeechVoicePriority.xml' path='doc/member[@name="SpeechVoicePriority.SVPOver"]/*' />
    SVPOver = SPVPRI_OVER,
}
