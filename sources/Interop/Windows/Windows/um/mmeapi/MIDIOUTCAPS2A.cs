// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MIDIOUTCAPS2A
{
    /// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A.szPname"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    /// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A.wTechnology"]/*' />
    [NativeTypeName("WORD")]
    public ushort wTechnology;

    /// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A.wVoices"]/*' />
    [NativeTypeName("WORD")]
    public ushort wVoices;

    /// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A.wNotes"]/*' />
    [NativeTypeName("WORD")]
    public ushort wNotes;

    /// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A.wChannelMask"]/*' />
    [NativeTypeName("WORD")]
    public ushort wChannelMask;

    /// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;

    /// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A.ManufacturerGuid"]/*' />
    public Guid ManufacturerGuid;

    /// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A.ProductGuid"]/*' />
    public Guid ProductGuid;

    /// <include file='MIDIOUTCAPS2A.xml' path='doc/member[@name="MIDIOUTCAPS2A.NameGuid"]/*' />
    public Guid NameGuid;

    /// <include file='_szPname_e__FixedBuffer.xml' path='doc/member[@name="_szPname_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    public partial struct _szPname_e__FixedBuffer
    {
        public sbyte e0;
    }
}
