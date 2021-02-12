// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcore_interface.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("uint32_t")]
    public enum DXCoreAdapterProperty : uint
    {
        InstanceLuid = 0,
        DriverVersion = 1,
        DriverDescription = 2,
        HardwareID = 3,
        KmdModelVersion = 4,
        ComputePreemptionGranularity = 5,
        GraphicsPreemptionGranularity = 6,
        DedicatedAdapterMemory = 7,
        DedicatedSystemMemory = 8,
        SharedSystemMemory = 9,
        AcgCompatible = 10,
        IsHardware = 11,
        IsIntegrated = 12,
        IsDetachable = 13,
    }
}
