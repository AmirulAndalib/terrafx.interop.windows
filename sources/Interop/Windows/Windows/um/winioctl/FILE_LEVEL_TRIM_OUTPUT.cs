// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_LEVEL_TRIM_OUTPUT.xml' path='doc/member[@name="FILE_LEVEL_TRIM_OUTPUT"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct FILE_LEVEL_TRIM_OUTPUT
{
    /// <include file='FILE_LEVEL_TRIM_OUTPUT.xml' path='doc/member[@name="FILE_LEVEL_TRIM_OUTPUT.NumRangesProcessed"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumRangesProcessed;
}
