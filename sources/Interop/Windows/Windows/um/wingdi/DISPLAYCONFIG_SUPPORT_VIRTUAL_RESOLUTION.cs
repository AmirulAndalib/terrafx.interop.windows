// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION.xml' path='doc/member[@name="DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION"]/*' />
[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION
{
    /// <include file='DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION.xml' path='doc/member[@name="DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION.header"]/*' />
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

    /// <include file='DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION.xml' path='doc/member[@name="DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION.Anonymous"]/*' />
    [NativeTypeName("DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wingdi.h:3135:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.disableMonitorVirtualResolution"]/*' />
    public uint disableMonitorVirtualResolution
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.disableMonitorVirtualResolution;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.disableMonitorVirtualResolution = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved"]/*' />
    public uint reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.reserved;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.reserved = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.value"]/*' />
    public ref uint value
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.value, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DISPLAYCONFIG_SUPPORT_VIRTUAL_RESOLUTION::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wingdi.h:3137:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.value"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint value;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.disableMonitorVirtualResolution"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint disableMonitorVirtualResolution
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved"]/*' />
            [NativeTypeName("UINT32 : 31")]
            public uint reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 1) & 0x7FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x7FFFFFFFu << 1)) | ((value & 0x7FFFFFFFu) << 1);
                }
            }
        }
    }
}
