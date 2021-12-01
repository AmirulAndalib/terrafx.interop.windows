// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='RemotableHandle.xml' path='doc/member[@name="RemotableHandle"]/*' />
public partial struct RemotableHandle
{
    /// <include file='RemotableHandle.xml' path='doc/member[@name="RemotableHandle.fContext"]/*' />
    [NativeTypeName("LONG")]
    public int fContext;

    /// <include file='RemotableHandle.xml' path='doc/member[@name="RemotableHandle.u"]/*' />
    [NativeTypeName("union __MIDL_IWinTypes_0009")]
    public _u_e__Union u;

    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hInproc"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LONG")]
        public int hInproc;

        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.hRemote"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LONG")]
        public int hRemote;
    }
}
