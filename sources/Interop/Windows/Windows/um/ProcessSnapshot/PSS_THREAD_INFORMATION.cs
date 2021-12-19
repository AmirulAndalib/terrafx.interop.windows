// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='PSS_THREAD_INFORMATION.xml' path='doc/member[@name="PSS_THREAD_INFORMATION"]/*' />
[SupportedOSPlatform("windows8.1")]
public partial struct PSS_THREAD_INFORMATION
{
    /// <include file='PSS_THREAD_INFORMATION.xml' path='doc/member[@name="PSS_THREAD_INFORMATION.ThreadsCaptured"]/*' />
    [NativeTypeName("DWORD")]
    public uint ThreadsCaptured;

    /// <include file='PSS_THREAD_INFORMATION.xml' path='doc/member[@name="PSS_THREAD_INFORMATION.ContextLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint ContextLength;
}
