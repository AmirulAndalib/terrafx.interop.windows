// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/projectedfslib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='PRJ_PLACEHOLDER_VERSION_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_VERSION_INFO"]/*' />
[SupportedOSPlatform("windows10.0.17763.0")]
public partial struct PRJ_PLACEHOLDER_VERSION_INFO
{
    /// <include file='PRJ_PLACEHOLDER_VERSION_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_VERSION_INFO.ProviderID"]/*' />
    [NativeTypeName("UINT8[128]")]
    public _ProviderID_e__FixedBuffer ProviderID;

    /// <include file='PRJ_PLACEHOLDER_VERSION_INFO.xml' path='doc/member[@name="PRJ_PLACEHOLDER_VERSION_INFO.ContentID"]/*' />
    [NativeTypeName("UINT8[128]")]
    public _ContentID_e__FixedBuffer ContentID;

    /// <include file='_ProviderID_e__FixedBuffer.xml' path='doc/member[@name="_ProviderID_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _ProviderID_e__FixedBuffer
    {
        public byte e0;
    }

    /// <include file='_ContentID_e__FixedBuffer.xml' path='doc/member[@name="_ContentID_e__FixedBuffer"]/*' />
    [InlineArray(128)]
    public partial struct _ContentID_e__FixedBuffer
    {
        public byte e0;
    }
}
