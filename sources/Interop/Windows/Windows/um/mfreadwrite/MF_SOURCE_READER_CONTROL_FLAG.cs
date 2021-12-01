// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='MF_SOURCE_READER_CONTROL_FLAG.xml' path='doc/member[@name="MF_SOURCE_READER_CONTROL_FLAG"]/*' />
[Flags]
public enum MF_SOURCE_READER_CONTROL_FLAG
{
    /// <include file='MF_SOURCE_READER_CONTROL_FLAG.xml' path='doc/member[@name="MF_SOURCE_READER_CONTROL_FLAG.MF_SOURCE_READER_CONTROLF_DRAIN"]/*' />
    MF_SOURCE_READER_CONTROLF_DRAIN = 0x1,
}
