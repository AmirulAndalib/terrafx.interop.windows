// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MSAAText.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("A2DE3BC1-3D8E-11D3-81A9-F753FBE61A00")]
[NativeTypeName("struct ITextStoreAnchorEx : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITextStoreAnchorEx : ITextStoreAnchorEx.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITextStoreAnchorEx*, Guid*, void**, int>)(lpVtbl[0]))((ITextStoreAnchorEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITextStoreAnchorEx*, uint>)(lpVtbl[1]))((ITextStoreAnchorEx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextStoreAnchorEx*, uint>)(lpVtbl[2]))((ITextStoreAnchorEx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ScrollToRect(IAnchor* pStart, IAnchor* pEnd, RECT rc, [NativeTypeName("DWORD")] uint dwPosition)
    {
        return ((delegate* unmanaged<ITextStoreAnchorEx*, IAnchor*, IAnchor*, RECT, uint, int>)(lpVtbl[3]))((ITextStoreAnchorEx*)Unsafe.AsPointer(ref this), pStart, pEnd, rc, dwPosition);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ScrollToRect(IAnchor* pStart, IAnchor* pEnd, RECT rc, [NativeTypeName("DWORD")] uint dwPosition);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ITextStoreAnchorEx*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ITextStoreAnchorEx*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ITextStoreAnchorEx*, uint> Release;

        [NativeTypeName("HRESULT (IAnchor *, IAnchor *, RECT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<ITextStoreAnchorEx*, IAnchor*, IAnchor*, RECT, uint, int> ScrollToRect;
    }
}
