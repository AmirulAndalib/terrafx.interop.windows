// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_SERVICE_PROPERTY_ACCEPT_CALLBACK
    {
        [NativeTypeName("WS_SERVICE_ACCEPT_CHANNEL_CALLBACK")]
        public delegate* unmanaged<IntPtr, void**, WS_ASYNC_CONTEXT*, IntPtr, int> callback;
    }
}
