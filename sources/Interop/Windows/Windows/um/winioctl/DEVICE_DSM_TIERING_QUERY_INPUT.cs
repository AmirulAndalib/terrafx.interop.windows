// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DEVICE_DSM_TIERING_QUERY_INPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_INPUT"]/*' />
public partial struct DEVICE_DSM_TIERING_QUERY_INPUT
{
    /// <include file='DEVICE_DSM_TIERING_QUERY_INPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_INPUT.Version"]/*' />
    [NativeTypeName("DWORD")]
    public uint Version;

    /// <include file='DEVICE_DSM_TIERING_QUERY_INPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_INPUT.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='DEVICE_DSM_TIERING_QUERY_INPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_INPUT.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='DEVICE_DSM_TIERING_QUERY_INPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_INPUT.NumberOfTierIds"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfTierIds;

    /// <include file='DEVICE_DSM_TIERING_QUERY_INPUT.xml' path='doc/member[@name="DEVICE_DSM_TIERING_QUERY_INPUT.TierIds"]/*' />
    [NativeTypeName("GUID[1]")]
    public _TierIds_e__FixedBuffer TierIds;

    /// <include file='_TierIds_e__FixedBuffer.xml' path='doc/member[@name="_TierIds_e__FixedBuffer"]/*' />
    public partial struct _TierIds_e__FixedBuffer
    {
        public Guid e0;

        public ref Guid this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<Guid> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
