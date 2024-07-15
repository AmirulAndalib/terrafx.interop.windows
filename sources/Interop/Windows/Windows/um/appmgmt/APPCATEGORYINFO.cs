// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmgmt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='APPCATEGORYINFO.xml' path='doc/member[@name="APPCATEGORYINFO"]/*' />
public unsafe partial struct APPCATEGORYINFO
{
    /// <include file='APPCATEGORYINFO.xml' path='doc/member[@name="APPCATEGORYINFO.Locale"]/*' />
    [NativeTypeName("LCID")]
    public uint Locale;

    /// <include file='APPCATEGORYINFO.xml' path='doc/member[@name="APPCATEGORYINFO.pszDescription"]/*' />
    [NativeTypeName("LPWSTR")]
    public char* pszDescription;

    /// <include file='APPCATEGORYINFO.xml' path='doc/member[@name="APPCATEGORYINFO.AppCategoryId"]/*' />
    public Guid AppCategoryId;
}
