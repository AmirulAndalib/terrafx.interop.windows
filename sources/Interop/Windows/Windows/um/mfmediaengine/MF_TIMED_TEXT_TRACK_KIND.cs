// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='MF_TIMED_TEXT_TRACK_KIND.xml' path='doc/member[@name="MF_TIMED_TEXT_TRACK_KIND"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum MF_TIMED_TEXT_TRACK_KIND
{
    /// <include file='MF_TIMED_TEXT_TRACK_KIND.xml' path='doc/member[@name="MF_TIMED_TEXT_TRACK_KIND.MF_TIMED_TEXT_TRACK_KIND_UNKNOWN"]/*' />
    MF_TIMED_TEXT_TRACK_KIND_UNKNOWN = 0,

    /// <include file='MF_TIMED_TEXT_TRACK_KIND.xml' path='doc/member[@name="MF_TIMED_TEXT_TRACK_KIND.MF_TIMED_TEXT_TRACK_KIND_SUBTITLES"]/*' />
    MF_TIMED_TEXT_TRACK_KIND_SUBTITLES = 1,

    /// <include file='MF_TIMED_TEXT_TRACK_KIND.xml' path='doc/member[@name="MF_TIMED_TEXT_TRACK_KIND.MF_TIMED_TEXT_TRACK_KIND_CAPTIONS"]/*' />
    MF_TIMED_TEXT_TRACK_KIND_CAPTIONS = 2,

    /// <include file='MF_TIMED_TEXT_TRACK_KIND.xml' path='doc/member[@name="MF_TIMED_TEXT_TRACK_KIND.MF_TIMED_TEXT_TRACK_KIND_METADATA"]/*' />
    MF_TIMED_TEXT_TRACK_KIND_METADATA = 3,
}
