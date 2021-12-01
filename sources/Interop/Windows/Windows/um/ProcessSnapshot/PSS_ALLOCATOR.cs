// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='PSS_ALLOCATOR.xml' path='doc/member[@name="PSS_ALLOCATOR"]/*' />
[SupportedOSPlatform("windows8.1")]
public unsafe partial struct PSS_ALLOCATOR
{
    /// <include file='PSS_ALLOCATOR.xml' path='doc/member[@name="PSS_ALLOCATOR.Context"]/*' />
    public void* Context;

    /// <include file='PSS_ALLOCATOR.xml' path='doc/member[@name="PSS_ALLOCATOR.AllocRoutine"]/*' />
    [NativeTypeName("void *(*)(void *, DWORD) __attribute__((stdcall))")]
    public delegate* unmanaged<void*, uint, void*> AllocRoutine;

    /// <include file='PSS_ALLOCATOR.xml' path='doc/member[@name="PSS_ALLOCATOR.FreeRoutine"]/*' />
    [NativeTypeName("void (*)(void *, void *) __attribute__((stdcall))")]
    public delegate* unmanaged<void*, void*, void> FreeRoutine;
}
