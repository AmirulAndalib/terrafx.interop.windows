// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='MF_TIMED_TEXT_ALIGNMENT.xml' path='doc/member[@name="MF_TIMED_TEXT_ALIGNMENT"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum MF_TIMED_TEXT_ALIGNMENT
{
    /// <include file='MF_TIMED_TEXT_ALIGNMENT.xml' path='doc/member[@name="MF_TIMED_TEXT_ALIGNMENT.MF_TIMED_TEXT_ALIGNMENT_START"]/*' />
    MF_TIMED_TEXT_ALIGNMENT_START = 0,

    /// <include file='MF_TIMED_TEXT_ALIGNMENT.xml' path='doc/member[@name="MF_TIMED_TEXT_ALIGNMENT.MF_TIMED_TEXT_ALIGNMENT_END"]/*' />
    MF_TIMED_TEXT_ALIGNMENT_END = 1,

    /// <include file='MF_TIMED_TEXT_ALIGNMENT.xml' path='doc/member[@name="MF_TIMED_TEXT_ALIGNMENT.MF_TIMED_TEXT_ALIGNMENT_CENTER"]/*' />
    MF_TIMED_TEXT_ALIGNMENT_CENTER = 2,
}
