// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DXGI_ADAPTER_DESC2
    {
        [NativeTypeName("WCHAR [128]")]
        public fixed ushort Description[128];

        public uint VendorId;

        public uint DeviceId;

        public uint SubSysId;

        public uint Revision;

        [NativeTypeName("SIZE_T")]
        public nuint DedicatedVideoMemory;

        [NativeTypeName("SIZE_T")]
        public nuint DedicatedSystemMemory;

        [NativeTypeName("SIZE_T")]
        public nuint SharedSystemMemory;

        public LUID AdapterLuid;

        public uint Flags;

        public DXGI_GRAPHICS_PREEMPTION_GRANULARITY GraphicsPreemptionGranularity;

        public DXGI_COMPUTE_PREEMPTION_GRANULARITY ComputePreemptionGranularity;
    }
}
