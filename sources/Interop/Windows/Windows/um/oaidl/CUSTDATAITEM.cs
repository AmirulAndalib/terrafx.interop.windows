// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='CUSTDATAITEM.xml' path='doc/member[@name="CUSTDATAITEM"]/*' />
public partial struct CUSTDATAITEM
{
    /// <include file='CUSTDATAITEM.xml' path='doc/member[@name="CUSTDATAITEM.guid"]/*' />
    public Guid guid;

    /// <include file='CUSTDATAITEM.xml' path='doc/member[@name="CUSTDATAITEM.varValue"]/*' />
    [NativeTypeName("VARIANTARG")]
    public VARIANT varValue;
}
