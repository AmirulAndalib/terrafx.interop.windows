// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows.SPAUDIOOPTIONS;

namespace TerraFX.Interop.Windows;

/// <include file='SpeechRetainedAudioOptions.xml' path='doc/member[@name="SpeechRetainedAudioOptions"]/*' />
public enum SpeechRetainedAudioOptions
{
    /// <include file='SpeechRetainedAudioOptions.xml' path='doc/member[@name="SpeechRetainedAudioOptions.SRAONone"]/*' />
    SRAONone = SPAO_NONE,

    /// <include file='SpeechRetainedAudioOptions.xml' path='doc/member[@name="SpeechRetainedAudioOptions.SRAORetainAudio"]/*' />
    SRAORetainAudio = SPAO_RETAIN_AUDIO,
}
