// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("4776F9CD-9517-45FA-BF24-E89C5EC5C60C")]
[NativeTypeName("struct IWICProgressCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICProgressCallback : IWICProgressCallback.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICProgressCallback*, Guid*, void**, int>)(lpVtbl[0]))((IWICProgressCallback*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICProgressCallback*, uint>)(lpVtbl[1]))((IWICProgressCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICProgressCallback*, uint>)(lpVtbl[2]))((IWICProgressCallback*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Notify([NativeTypeName("ULONG")] uint uFrameNum, WICProgressOperation operation, double dblProgress)
    {
        return ((delegate* unmanaged<IWICProgressCallback*, uint, WICProgressOperation, double, int>)(lpVtbl[3]))((IWICProgressCallback*)Unsafe.AsPointer(ref this), uFrameNum, operation, dblProgress);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Notify([NativeTypeName("ULONG")] uint uFrameNum, WICProgressOperation operation, double dblProgress);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICProgressCallback*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWICProgressCallback*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IWICProgressCallback*, uint> Release;

        [NativeTypeName("HRESULT (ULONG, WICProgressOperation, double) __attribute__((stdcall))")]
        public delegate* unmanaged<IWICProgressCallback*, uint, WICProgressOperation, double, int> Notify;
    }
}
