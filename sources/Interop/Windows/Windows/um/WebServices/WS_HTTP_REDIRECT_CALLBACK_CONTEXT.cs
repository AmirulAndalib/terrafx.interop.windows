// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_HTTP_REDIRECT_CALLBACK_CONTEXT.xml' path='doc/member[@name="WS_HTTP_REDIRECT_CALLBACK_CONTEXT"]/*' />
public unsafe partial struct WS_HTTP_REDIRECT_CALLBACK_CONTEXT
{
    /// <include file='WS_HTTP_REDIRECT_CALLBACK_CONTEXT.xml' path='doc/member[@name="WS_HTTP_REDIRECT_CALLBACK_CONTEXT.callback"]/*' />
    [NativeTypeName("WS_HTTP_REDIRECT_CALLBACK")]
    public delegate* unmanaged<void*, WS_STRING*, WS_STRING*, HRESULT> callback;

    /// <include file='WS_HTTP_REDIRECT_CALLBACK_CONTEXT.xml' path='doc/member[@name="WS_HTTP_REDIRECT_CALLBACK_CONTEXT.state"]/*' />
    public void* state;
}
