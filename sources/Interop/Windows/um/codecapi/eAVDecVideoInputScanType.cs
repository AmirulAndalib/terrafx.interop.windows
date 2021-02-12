// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum eAVDecVideoInputScanType
    {
        eAVDecVideoInputScan_Unknown = 0,
        eAVDecVideoInputScan_Progressive = 1,
        eAVDecVideoInputScan_Interlaced_UpperFieldFirst = 2,
        eAVDecVideoInputScan_Interlaced_LowerFieldFirst = 3,
    }
}
