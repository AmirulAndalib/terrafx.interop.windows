// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSChapp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='SAMPR_ENCRYPTED_USER_PASSWORD.xml' path='doc/member[@name="SAMPR_ENCRYPTED_USER_PASSWORD"]/*' />
public partial struct SAMPR_ENCRYPTED_USER_PASSWORD
{
    /// <include file='SAMPR_ENCRYPTED_USER_PASSWORD.xml' path='doc/member[@name="SAMPR_ENCRYPTED_USER_PASSWORD.Buffer"]/*' />
    [NativeTypeName("UCHAR[516]")]
    public _Buffer_e__FixedBuffer Buffer;

    /// <include file='_Buffer_e__FixedBuffer.xml' path='doc/member[@name="_Buffer_e__FixedBuffer"]/*' />
    [InlineArray(516)]
    public partial struct _Buffer_e__FixedBuffer
    {
        public byte e0;
    }
}
