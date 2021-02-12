// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum STORAGE_COUNTER_TYPE
    {
        StorageCounterTypeUnknown = 0,
        StorageCounterTypeTemperatureCelsius,
        StorageCounterTypeTemperatureCelsiusMax,
        StorageCounterTypeReadErrorsTotal,
        StorageCounterTypeReadErrorsCorrected,
        StorageCounterTypeReadErrorsUncorrected,
        StorageCounterTypeWriteErrorsTotal,
        StorageCounterTypeWriteErrorsCorrected,
        StorageCounterTypeWriteErrorsUncorrected,
        StorageCounterTypeManufactureDate,
        StorageCounterTypeStartStopCycleCount,
        StorageCounterTypeStartStopCycleCountMax,
        StorageCounterTypeLoadUnloadCycleCount,
        StorageCounterTypeLoadUnloadCycleCountMax,
        StorageCounterTypeWearPercentage,
        StorageCounterTypeWearPercentageWarning,
        StorageCounterTypeWearPercentageMax,
        StorageCounterTypePowerOnHours,
        StorageCounterTypeReadLatency100NSMax,
        StorageCounterTypeWriteLatency100NSMax,
        StorageCounterTypeFlushLatency100NSMax,
        StorageCounterTypeMax,
    }
}
