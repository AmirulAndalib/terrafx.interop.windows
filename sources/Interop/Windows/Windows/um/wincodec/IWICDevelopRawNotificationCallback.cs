// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("95C75A6E-3E8C-4EC2-85A8-AEBCC551E59B")]
[NativeTypeName("struct IWICDevelopRawNotificationCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICDevelopRawNotificationCallback : IWICDevelopRawNotificationCallback.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICDevelopRawNotificationCallback*, Guid*, void**, int>)(lpVtbl[0]))((IWICDevelopRawNotificationCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICDevelopRawNotificationCallback*, uint>)(lpVtbl[1]))((IWICDevelopRawNotificationCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICDevelopRawNotificationCallback*, uint>)(lpVtbl[2]))((IWICDevelopRawNotificationCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Notify(uint NotificationMask)
    {
        return ((delegate* unmanaged<IWICDevelopRawNotificationCallback*, uint, int>)(lpVtbl[3]))((IWICDevelopRawNotificationCallback*)Unsafe.AsPointer(ref this), NotificationMask);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Notify(uint NotificationMask);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICDevelopRawNotificationCallback*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWICDevelopRawNotificationCallback*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWICDevelopRawNotificationCallback*, uint> Release;

        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICDevelopRawNotificationCallback*, uint, int> Notify;
    }
}
