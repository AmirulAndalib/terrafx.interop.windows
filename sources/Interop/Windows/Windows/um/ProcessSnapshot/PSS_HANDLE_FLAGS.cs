// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='PSS_HANDLE_FLAGS.xml' path='doc/member[@name="PSS_HANDLE_FLAGS"]/*' />
[Flags]
[SupportedOSPlatform("windows6.3")]
public enum PSS_HANDLE_FLAGS
{
    /// <include file='PSS_HANDLE_FLAGS.xml' path='doc/member[@name="PSS_HANDLE_FLAGS.PSS_HANDLE_NONE"]/*' />
    PSS_HANDLE_NONE = 0x00,

    /// <include file='PSS_HANDLE_FLAGS.xml' path='doc/member[@name="PSS_HANDLE_FLAGS.PSS_HANDLE_HAVE_TYPE"]/*' />
    PSS_HANDLE_HAVE_TYPE = 0x01,

    /// <include file='PSS_HANDLE_FLAGS.xml' path='doc/member[@name="PSS_HANDLE_FLAGS.PSS_HANDLE_HAVE_NAME"]/*' />
    PSS_HANDLE_HAVE_NAME = 0x02,

    /// <include file='PSS_HANDLE_FLAGS.xml' path='doc/member[@name="PSS_HANDLE_FLAGS.PSS_HANDLE_HAVE_BASIC_INFORMATION"]/*' />
    PSS_HANDLE_HAVE_BASIC_INFORMATION = 0x04,

    /// <include file='PSS_HANDLE_FLAGS.xml' path='doc/member[@name="PSS_HANDLE_FLAGS.PSS_HANDLE_HAVE_TYPE_SPECIFIC_INFORMATION"]/*' />
    PSS_HANDLE_HAVE_TYPE_SPECIFIC_INFORMATION = 0x08,
}
