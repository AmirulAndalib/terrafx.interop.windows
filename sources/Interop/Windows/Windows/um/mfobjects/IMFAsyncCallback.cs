// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("A27003CF-2354-4F2A-8D6A-AB7CFF15437E")]
[NativeTypeName("struct IMFAsyncCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFAsyncCallback : IMFAsyncCallback.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFAsyncCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFAsyncCallback*, uint>)(lpVtbl[1]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFAsyncCallback*, uint>)(lpVtbl[2]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetParameters([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD *")] uint* pdwQueue)
    {
        return ((delegate* unmanaged<IMFAsyncCallback*, uint*, uint*, int>)(lpVtbl[3]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this), pdwFlags, pdwQueue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Invoke(IMFAsyncResult* pAsyncResult)
    {
        return ((delegate* unmanaged<IMFAsyncCallback*, IMFAsyncResult*, int>)(lpVtbl[4]))((IMFAsyncCallback*)Unsafe.AsPointer(ref this), pAsyncResult);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetParameters([NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD *")] uint* pdwQueue);

        [VtblIndex(4)]
        HRESULT Invoke(IMFAsyncResult* pAsyncResult);
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

        [NativeTypeName("HRESULT (DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetParameters;

        [NativeTypeName("HRESULT (IMFAsyncResult *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncResult*, int> Invoke;
    }
}
