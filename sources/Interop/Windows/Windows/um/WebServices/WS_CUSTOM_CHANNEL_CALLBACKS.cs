// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS"]/*' />
public unsafe partial struct WS_CUSTOM_CHANNEL_CALLBACKS
{
    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.createChannelCallback"]/*' />
    [NativeTypeName("WS_CREATE_CHANNEL_CALLBACK")]
    public delegate* unmanaged<WS_CHANNEL_TYPE, void*, uint, void**, void*, HRESULT> createChannelCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.freeChannelCallback"]/*' />
    [NativeTypeName("WS_FREE_CHANNEL_CALLBACK")]
    public delegate* unmanaged<void*, void> freeChannelCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.resetChannelCallback"]/*' />
    [NativeTypeName("WS_RESET_CHANNEL_CALLBACK")]
    public delegate* unmanaged<void*, void*, HRESULT> resetChannelCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.openChannelCallback"]/*' />
    [NativeTypeName("WS_OPEN_CHANNEL_CALLBACK")]
    public delegate* unmanaged<void*, WS_ENDPOINT_ADDRESS*, WS_ASYNC_CONTEXT*, void*, HRESULT> openChannelCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.closeChannelCallback"]/*' />
    [NativeTypeName("WS_CLOSE_CHANNEL_CALLBACK")]
    public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, void*, HRESULT> closeChannelCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.abortChannelCallback"]/*' />
    [NativeTypeName("WS_ABORT_CHANNEL_CALLBACK")]
    public delegate* unmanaged<void*, void*, HRESULT> abortChannelCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.getChannelPropertyCallback"]/*' />
    [NativeTypeName("WS_GET_CHANNEL_PROPERTY_CALLBACK")]
    public delegate* unmanaged<void*, WS_CHANNEL_PROPERTY_ID, void*, uint, void*, HRESULT> getChannelPropertyCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.setChannelPropertyCallback"]/*' />
    [NativeTypeName("WS_SET_CHANNEL_PROPERTY_CALLBACK")]
    public delegate* unmanaged<void*, WS_CHANNEL_PROPERTY_ID, void*, uint, void*, HRESULT> setChannelPropertyCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.writeMessageStartCallback"]/*' />
    [NativeTypeName("WS_WRITE_MESSAGE_START_CALLBACK")]
    public delegate* unmanaged<void*, void*, WS_ASYNC_CONTEXT*, void*, HRESULT> writeMessageStartCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.writeMessageEndCallback"]/*' />
    [NativeTypeName("WS_WRITE_MESSAGE_END_CALLBACK")]
    public delegate* unmanaged<void*, void*, WS_ASYNC_CONTEXT*, void*, HRESULT> writeMessageEndCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.readMessageStartCallback"]/*' />
    [NativeTypeName("WS_READ_MESSAGE_START_CALLBACK")]
    public delegate* unmanaged<void*, void*, WS_ASYNC_CONTEXT*, void*, HRESULT> readMessageStartCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.readMessageEndCallback"]/*' />
    [NativeTypeName("WS_READ_MESSAGE_END_CALLBACK")]
    public delegate* unmanaged<void*, void*, WS_ASYNC_CONTEXT*, void*, HRESULT> readMessageEndCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.abandonMessageCallback"]/*' />
    [NativeTypeName("WS_ABANDON_MESSAGE_CALLBACK")]
    public delegate* unmanaged<void*, void*, void*, HRESULT> abandonMessageCallback;

    /// <include file='WS_CUSTOM_CHANNEL_CALLBACKS.xml' path='doc/member[@name="WS_CUSTOM_CHANNEL_CALLBACKS.shutdownSessionChannelCallback"]/*' />
    [NativeTypeName("WS_SHUTDOWN_SESSION_CHANNEL_CALLBACK")]
    public delegate* unmanaged<void*, WS_ASYNC_CONTEXT*, void*, HRESULT> shutdownSessionChannelCallback;
}
