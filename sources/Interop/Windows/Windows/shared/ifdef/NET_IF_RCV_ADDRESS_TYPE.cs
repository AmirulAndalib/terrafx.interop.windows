// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ifdef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum NET_IF_RCV_ADDRESS_TYPE
    {
        NET_IF_RCV_ADDRESS_TYPE_OTHER = 1,
        NET_IF_RCV_ADDRESS_TYPE_VOLATILE = 2,
        NET_IF_RCV_ADDRESS_TYPE_NON_VOLATILE = 3,
    }
}