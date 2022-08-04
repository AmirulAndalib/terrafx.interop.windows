// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS"]/*' />
public partial struct DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS
{
    /// <include file='DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS.Anonymous"]/*' />
    [NativeTypeName("DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/wingdi.h:3079:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.friendlyNameFromEdid"]/*' />
    [UnscopedRef]
    public uint friendlyNameFromEdid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.friendlyNameFromEdid;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.friendlyNameFromEdid = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.friendlyNameForced"]/*' />
    [UnscopedRef]
    public uint friendlyNameForced
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.friendlyNameForced;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.friendlyNameForced = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.edidIdsValid"]/*' />
    [UnscopedRef]
    public uint edidIdsValid
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.edidIdsValid;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.edidIdsValid = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved"]/*' />
    [UnscopedRef]
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
    [UnscopedRef]
    public ref uint value
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DISPLAYCONFIG_TARGET_DEVICE_NAME_FLAGS::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/wingdi.h:3081:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.value"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint value;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.friendlyNameFromEdid"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint friendlyNameFromEdid
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.friendlyNameForced"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint friendlyNameForced
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 1) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.edidIdsValid"]/*' />
            [NativeTypeName("UINT32 : 1")]
            public uint edidIdsValid
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 2) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved"]/*' />
            [NativeTypeName("UINT32 : 29")]
            public uint reserved
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 3) & 0x1FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1FFFFFFFu << 3)) | ((value & 0x1FFFFFFFu) << 3);
                }
            }
        }
    }
}
