// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum STORAGE_IDENTIFIER_TYPE
    {
        StorageIdTypeVendorSpecific = 0,
        StorageIdTypeVendorId = 1,
        StorageIdTypeEUI64 = 2,
        StorageIdTypeFCPHName = 3,
        StorageIdTypePortRelative = 4,
        StorageIdTypeTargetPortGroup = 5,
        StorageIdTypeLogicalUnitGroup = 6,
        StorageIdTypeMD5LogicalUnitIdentifier = 7,
        StorageIdTypeScsiNameString = 8,
    }
}
