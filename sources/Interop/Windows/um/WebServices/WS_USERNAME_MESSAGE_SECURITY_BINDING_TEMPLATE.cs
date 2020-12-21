// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WS_USERNAME_MESSAGE_SECURITY_BINDING_TEMPLATE
    {
        public WS_SECURITY_BINDING_PROPERTIES securityBindingProperties;

        [NativeTypeName("WS_USERNAME_CREDENTIAL *")]
        public WS_USERNAME_CREDENTIAL* clientCredential;

        [NativeTypeName("WS_VALIDATE_PASSWORD_CALLBACK")]
        public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, WS_ASYNC_CONTEXT*, IntPtr, int> passwordValidator;

        [NativeTypeName("void *")]
        public void* passwordValidatorCallbackState;
    }
}
