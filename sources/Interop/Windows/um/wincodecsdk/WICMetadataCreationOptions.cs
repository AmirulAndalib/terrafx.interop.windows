// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WICMetadataCreationOptions
    {
        WICMetadataCreationDefault = 0,
        WICMetadataCreationAllowUnknown = WICMetadataCreationDefault,
        WICMetadataCreationFailUnknown = 0x10000,
        WICMetadataCreationMask = unchecked((int)(0xffff0000)),
    }
}
