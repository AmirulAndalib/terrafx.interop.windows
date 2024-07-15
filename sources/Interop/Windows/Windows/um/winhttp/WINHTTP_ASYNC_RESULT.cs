// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_ASYNC_RESULT.xml' path='doc/member[@name="WINHTTP_ASYNC_RESULT"]/*' />
public partial struct WINHTTP_ASYNC_RESULT
{
    /// <include file='WINHTTP_ASYNC_RESULT.xml' path='doc/member[@name="WINHTTP_ASYNC_RESULT.dwResult"]/*' />
    [NativeTypeName("DWORD_PTR")]
    public nuint dwResult;

    /// <include file='WINHTTP_ASYNC_RESULT.xml' path='doc/member[@name="WINHTTP_ASYNC_RESULT.dwError"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwError;
}
