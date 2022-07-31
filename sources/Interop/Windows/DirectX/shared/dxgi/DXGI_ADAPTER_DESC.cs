// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC"]/*' />
public unsafe partial struct DXGI_ADAPTER_DESC
{
    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.Description"]/*' />
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort Description[128];

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.VendorId"]/*' />
    public uint VendorId;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.DeviceId"]/*' />
    public uint DeviceId;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.SubSysId"]/*' />
    public uint SubSysId;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.Revision"]/*' />
    public uint Revision;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.DedicatedVideoMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint DedicatedVideoMemory;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.DedicatedSystemMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint DedicatedSystemMemory;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.SharedSystemMemory"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint SharedSystemMemory;

    /// <include file='DXGI_ADAPTER_DESC.xml' path='doc/member[@name="DXGI_ADAPTER_DESC.AdapterLuid"]/*' />
    public LUID AdapterLuid;
}
