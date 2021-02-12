// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MF_TOPOLOGY_RESOLUTION_STATUS_FLAGS
    {
        MF_TOPOLOGY_RESOLUTION_SUCCEEDED = 0,
        MF_OPTIONAL_NODE_REJECTED_MEDIA_TYPE = 0x1,
        MF_OPTIONAL_NODE_REJECTED_PROTECTED_PROCESS = 0x2,
    }
}
