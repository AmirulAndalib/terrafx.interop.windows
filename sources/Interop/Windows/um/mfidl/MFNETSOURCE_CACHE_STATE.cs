// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFNETSOURCE_CACHE_STATE
    {
        MFNETSOURCE_CACHE_UNAVAILABLE = 0,
        MFNETSOURCE_CACHE_ACTIVE_WRITING = (MFNETSOURCE_CACHE_UNAVAILABLE + 1),
        MFNETSOURCE_CACHE_ACTIVE_COMPLETE = (MFNETSOURCE_CACHE_ACTIVE_WRITING + 1),
    }
}
