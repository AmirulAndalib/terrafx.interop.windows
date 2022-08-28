// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='MFSampleAllocatorUsage.xml' path='doc/member[@name="MFSampleAllocatorUsage"]/*' />
[SupportedOSPlatform("windows10.0.19041.0")]
public enum MFSampleAllocatorUsage
{
    /// <include file='MFSampleAllocatorUsage.xml' path='doc/member[@name="MFSampleAllocatorUsage.MFSampleAllocatorUsage_UsesProvidedAllocator"]/*' />
    MFSampleAllocatorUsage_UsesProvidedAllocator = 0,

    /// <include file='MFSampleAllocatorUsage.xml' path='doc/member[@name="MFSampleAllocatorUsage.MFSampleAllocatorUsage_UsesCustomAllocator"]/*' />
    MFSampleAllocatorUsage_UsesCustomAllocator = (MFSampleAllocatorUsage_UsesProvidedAllocator + 1),

    /// <include file='MFSampleAllocatorUsage.xml' path='doc/member[@name="MFSampleAllocatorUsage.MFSampleAllocatorUsage_DoesNotAllocate"]/*' />
    MFSampleAllocatorUsage_DoesNotAllocate = (MFSampleAllocatorUsage_UsesCustomAllocator + 1),
}
