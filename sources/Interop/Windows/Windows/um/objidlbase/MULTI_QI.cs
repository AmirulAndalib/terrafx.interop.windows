// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='MULTI_QI.xml' path='doc/member[@name="MULTI_QI"]/*' />
public unsafe partial struct MULTI_QI
{
    /// <include file='MULTI_QI.xml' path='doc/member[@name="MULTI_QI.pIID"]/*' />
    [NativeTypeName("const IID *")]
    public Guid* pIID;

    /// <include file='MULTI_QI.xml' path='doc/member[@name="MULTI_QI.pItf"]/*' />
    public IUnknown* pItf;

    /// <include file='MULTI_QI.xml' path='doc/member[@name="MULTI_QI.hr"]/*' />
    public HRESULT hr;
}
