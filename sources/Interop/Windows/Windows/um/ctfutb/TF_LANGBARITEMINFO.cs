// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='TF_LANGBARITEMINFO.xml' path='doc/member[@name="TF_LANGBARITEMINFO"]/*' />
public partial struct TF_LANGBARITEMINFO
{
    /// <include file='TF_LANGBARITEMINFO.xml' path='doc/member[@name="TF_LANGBARITEMINFO.clsidService"]/*' />
    [NativeTypeName("CLSID")]
    public Guid clsidService;

    /// <include file='TF_LANGBARITEMINFO.xml' path='doc/member[@name="TF_LANGBARITEMINFO.guidItem"]/*' />
    public Guid guidItem;

    /// <include file='TF_LANGBARITEMINFO.xml' path='doc/member[@name="TF_LANGBARITEMINFO.dwStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStyle;

    /// <include file='TF_LANGBARITEMINFO.xml' path='doc/member[@name="TF_LANGBARITEMINFO.ulSort"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulSort;

    /// <include file='TF_LANGBARITEMINFO.xml' path='doc/member[@name="TF_LANGBARITEMINFO.szDescription"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public _szDescription_e__FixedBuffer szDescription;

    /// <include file='_szDescription_e__FixedBuffer.xml' path='doc/member[@name="_szDescription_e__FixedBuffer"]/*' />
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szDescription_e__FixedBuffer
    {
        public char e0;
    }
}
