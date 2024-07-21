// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='userHPALETTE.xml' path='doc/member[@name="userHPALETTE"]/*' />
public partial struct userHPALETTE
{
    /// <include file='userHPALETTE.xml' path='doc/member[@name="userHPALETTE.fContext"]/*' />
    [NativeTypeName("LONG")]
    public int fContext;

    /// <include file='userHPALETTE.xml' path='doc/member[@name="userHPALETTE.u"]/*' />
    [NativeTypeName("union __MIDL_IWinTypes_0008")]
    public _u_e__Union u;

    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hInproc"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LONG")]
        public int hInproc;

        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hRemote"]/*' />
        [FieldOffset(0)]
        public LOGPALETTE* hRemote;

        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hInproc64"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("long long")]
        public long hInproc64;
    }
}
