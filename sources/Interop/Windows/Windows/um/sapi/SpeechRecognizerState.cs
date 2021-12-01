// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SPRECOSTATE;

namespace TerraFX.Interop.Windows;

/// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState"]/*' />
public enum SpeechRecognizerState
{
    /// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState.SRSInactive"]/*' />
    SRSInactive = SPRST_INACTIVE,

    /// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState.SRSActive"]/*' />
    SRSActive = SPRST_ACTIVE,

    /// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState.SRSActiveAlways"]/*' />
    SRSActiveAlways = SPRST_ACTIVE_ALWAYS,

    /// <include file='SpeechRecognizerState.xml' path='doc/member[@name="SpeechRecognizerState.SRSInactiveWithPurge"]/*' />
    SRSInactiveWithPurge = SPRST_INACTIVE_WITH_PURGE,
}
