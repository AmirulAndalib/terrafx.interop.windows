// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SPSERIALIZEDEVENT.xml' path='doc/member[@name="SPSERIALIZEDEVENT"]/*' />
public partial struct SPSERIALIZEDEVENT
{
    public int _bitfield;

    /// <include file='SPSERIALIZEDEVENT.xml' path='doc/member[@name="SPSERIALIZEDEVENT.eEventId"]/*' />
    [NativeTypeName("SPEVENTENUM : 16")]
    public SPEVENTENUM eEventId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (SPEVENTENUM)((_bitfield << 16) >> 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0xFFFF) | ((int)(value) & 0xFFFF);
        }
    }

    /// <include file='SPSERIALIZEDEVENT.xml' path='doc/member[@name="SPSERIALIZEDEVENT.elParamType"]/*' />
    [NativeTypeName("SPEVENTLPARAMTYPE : 16")]
    public SPEVENTLPARAMTYPE elParamType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get
        {
            return (SPEVENTLPARAMTYPE)((_bitfield << 0) >> 16);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFFFF << 16)) | (((int)(value) & 0xFFFF) << 16);
        }
    }

    /// <include file='SPSERIALIZEDEVENT.xml' path='doc/member[@name="SPSERIALIZEDEVENT.ulStreamNum"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulStreamNum;

    /// <include file='SPSERIALIZEDEVENT.xml' path='doc/member[@name="SPSERIALIZEDEVENT.ullAudioStreamOffset"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullAudioStreamOffset;

    /// <include file='SPSERIALIZEDEVENT.xml' path='doc/member[@name="SPSERIALIZEDEVENT.SerializedwParam"]/*' />
    [NativeTypeName("ULONG")]
    public uint SerializedwParam;

    /// <include file='SPSERIALIZEDEVENT.xml' path='doc/member[@name="SPSERIALIZEDEVENT.SerializedlParam"]/*' />
    [NativeTypeName("LONG")]
    public int SerializedlParam;
}
