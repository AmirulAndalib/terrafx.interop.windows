// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='INTERFACEINFO.xml' path='doc/member[@name="INTERFACEINFO"]/*' />
public unsafe partial struct INTERFACEINFO
{
    /// <include file='INTERFACEINFO.xml' path='doc/member[@name="INTERFACEINFO.pUnk"]/*' />
    public IUnknown* pUnk;

    /// <include file='INTERFACEINFO.xml' path='doc/member[@name="INTERFACEINFO.iid"]/*' />
    [NativeTypeName("IID")]
    public Guid iid;

    /// <include file='INTERFACEINFO.xml' path='doc/member[@name="INTERFACEINFO.wMethod"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMethod;
}
