// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='ENCLAVE_CREATE_INFO_SGX.xml' path='doc/member[@name="ENCLAVE_CREATE_INFO_SGX"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct ENCLAVE_CREATE_INFO_SGX
{
    /// <include file='ENCLAVE_CREATE_INFO_SGX.xml' path='doc/member[@name="ENCLAVE_CREATE_INFO_SGX.Secs"]/*' />
    [NativeTypeName("BYTE[4096]")]
    public _Secs_e__FixedBuffer Secs;

    /// <include file='_Secs_e__FixedBuffer.xml' path='doc/member[@name="_Secs_e__FixedBuffer"]/*' />
    [InlineArray(4096)]
    public partial struct _Secs_e__FixedBuffer
    {
        public byte e0;
    }
}
