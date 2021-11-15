// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipifcons.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum IF_ACCESS_TYPE
    {
        IF_ACCESS_LOOPBACK = 1,
        IF_ACCESS_BROADCAST = 2,
        IF_ACCESS_POINT_TO_POINT = 3,
        IF_ACCESS_POINTTOPOINT = 3,
        IF_ACCESS_POINT_TO_MULTI_POINT = 4,
        IF_ACCESS_POINTTOMULTIPOINT = 4,
    }
}