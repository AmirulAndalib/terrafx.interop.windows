// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfreadwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("666F76DE-33D2-41B9-A458-29ED0A972C58")]
[NativeTypeName("struct IMFSinkWriterCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFSinkWriterCallback : IMFSinkWriterCallback.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback*, Guid*, void**, int>)(lpVtbl[0]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback*, uint>)(lpVtbl[1]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback*, uint>)(lpVtbl[2]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnFinalize(HRESULT hrStatus)
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback*, HRESULT, int>)(lpVtbl[3]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this), hrStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnMarker([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LPVOID")] void* pvContext)
    {
        return ((delegate* unmanaged<IMFSinkWriterCallback*, uint, void*, int>)(lpVtbl[4]))((IMFSinkWriterCallback*)Unsafe.AsPointer(ref this), dwStreamIndex, pvContext);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnFinalize(HRESULT hrStatus);

        [VtblIndex(4)]
        HRESULT OnMarker([NativeTypeName("DWORD")] uint dwStreamIndex, [NativeTypeName("LPVOID")] void* pvContext);
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

        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> OnFinalize;

        [NativeTypeName("HRESULT (DWORD, LPVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, int> OnMarker;
    }
}
