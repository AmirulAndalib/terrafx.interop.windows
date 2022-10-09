// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='PROCESS_MITIGATION_SYSTEM_CALL_DISABLE_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_SYSTEM_CALL_DISABLE_POLICY"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct PROCESS_MITIGATION_SYSTEM_CALL_DISABLE_POLICY
{
    /// <include file='PROCESS_MITIGATION_SYSTEM_CALL_DISABLE_POLICY.xml' path='doc/member[@name="PROCESS_MITIGATION_SYSTEM_CALL_DISABLE_POLICY.Anonymous"]/*' />
    [NativeTypeName("_PROCESS_MITIGATION_SYSTEM_CALL_DISABLE_POLICY::(anonymous union at C:/Program Files (x86)/Windows Kits/10/include/10.0.22621.0/um/winnt.h:12593:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
    [UnscopedRef]
    public ref uint Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Flags;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DisallowWin32kSystemCalls"]/*' />
    public uint DisallowWin32kSystemCalls
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.DisallowWin32kSystemCalls;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.DisallowWin32kSystemCalls = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditDisallowWin32kSystemCalls"]/*' />
    public uint AuditDisallowWin32kSystemCalls
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.AuditDisallowWin32kSystemCalls;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.AuditDisallowWin32kSystemCalls = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedFlags"]/*' />
    public uint ReservedFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.ReservedFlags;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.ReservedFlags = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Flags;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("_PROCESS_MITIGATION_SYSTEM_CALL_DISABLE_POLICY::(anonymous struct at C:/Program Files (x86)/Windows Kits/10/include/10.0.22621.0/um/winnt.h:12595:9)")]
        public _Anonymous_e__Struct Anonymous;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DisallowWin32kSystemCalls"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint DisallowWin32kSystemCalls
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.AuditDisallowWin32kSystemCalls"]/*' />
            [NativeTypeName("DWORD : 1")]
            public uint AuditDisallowWin32kSystemCalls
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

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ReservedFlags"]/*' />
            [NativeTypeName("DWORD : 30")]
            public uint ReservedFlags
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 2) & 0x3FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
                }
            }
        }
    }
}
