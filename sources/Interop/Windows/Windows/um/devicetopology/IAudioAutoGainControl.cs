// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("85401FD4-6DE4-4B9D-9869-2D6753A82F3C")]
[NativeTypeName("struct IAudioAutoGainControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioAutoGainControl : IAudioAutoGainControl.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAudioAutoGainControl*, Guid*, void**, int>)(lpVtbl[0]))((IAudioAutoGainControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAudioAutoGainControl*, uint>)(lpVtbl[1]))((IAudioAutoGainControl*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAudioAutoGainControl*, uint>)(lpVtbl[2]))((IAudioAutoGainControl*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetEnabled(BOOL* pbEnabled)
    {
        return ((delegate* unmanaged<IAudioAutoGainControl*, BOOL*, int>)(lpVtbl[3]))((IAudioAutoGainControl*)Unsafe.AsPointer(ref this), pbEnabled);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetEnabled(BOOL bEnable, [NativeTypeName("LPCGUID")] Guid* pguidEventContext)
    {
        return ((delegate* unmanaged<IAudioAutoGainControl*, BOOL, Guid*, int>)(lpVtbl[4]))((IAudioAutoGainControl*)Unsafe.AsPointer(ref this), bEnable, pguidEventContext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetEnabled(BOOL* pbEnabled);

        [VtblIndex(4)]
        HRESULT SetEnabled(BOOL bEnable, [NativeTypeName("LPCGUID")] Guid* pguidEventContext);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetEnabled;

        [NativeTypeName("HRESULT (BOOL, LPCGUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, Guid*, int> SetEnabled;
    }
}
