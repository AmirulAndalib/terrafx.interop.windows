// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSChapp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='ENCRYPTED_LM_OWF_PASSWORD.xml' path='doc/member[@name="ENCRYPTED_LM_OWF_PASSWORD"]/*' />
public partial struct ENCRYPTED_LM_OWF_PASSWORD
{
    /// <include file='ENCRYPTED_LM_OWF_PASSWORD.xml' path='doc/member[@name="ENCRYPTED_LM_OWF_PASSWORD.data"]/*' />
    [NativeTypeName("CYPHER_BLOCK[2]")]
    public _data_e__FixedBuffer data;

    /// <include file='_data_e__FixedBuffer.xml' path='doc/member[@name="_data_e__FixedBuffer"]/*' />
    [InlineArray(2)]
    public partial struct _data_e__FixedBuffer
    {
        public CYPHER_BLOCK e0;
    }
}
