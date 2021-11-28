// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("A248FD3F-3E6C-4E63-9F03-7F68ECC91DB9")]
[NativeTypeName("struct ID2D1EffectImpl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID2D1EffectImpl : ID2D1EffectImpl.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1EffectImpl*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1EffectImpl*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1EffectImpl*, uint>)(lpVtbl[1]))((ID2D1EffectImpl*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1EffectImpl*, uint>)(lpVtbl[2]))((ID2D1EffectImpl*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(ID2D1EffectContext* effectContext, ID2D1TransformGraph* transformGraph)
    {
        return ((delegate* unmanaged<ID2D1EffectImpl*, ID2D1EffectContext*, ID2D1TransformGraph*, int>)(lpVtbl[3]))((ID2D1EffectImpl*)Unsafe.AsPointer(ref this), effectContext, transformGraph);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PrepareForRender(D2D1_CHANGE_TYPE changeType)
    {
        return ((delegate* unmanaged<ID2D1EffectImpl*, D2D1_CHANGE_TYPE, int>)(lpVtbl[4]))((ID2D1EffectImpl*)Unsafe.AsPointer(ref this), changeType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetGraph(ID2D1TransformGraph* transformGraph)
    {
        return ((delegate* unmanaged<ID2D1EffectImpl*, ID2D1TransformGraph*, int>)(lpVtbl[5]))((ID2D1EffectImpl*)Unsafe.AsPointer(ref this), transformGraph);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(ID2D1EffectContext* effectContext, ID2D1TransformGraph* transformGraph);

        [VtblIndex(4)]
        HRESULT PrepareForRender(D2D1_CHANGE_TYPE changeType);

        [VtblIndex(5)]
        HRESULT SetGraph(ID2D1TransformGraph* transformGraph);
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

        [NativeTypeName("HRESULT (ID2D1EffectContext *, ID2D1TransformGraph *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1EffectContext*, ID2D1TransformGraph*, int> Initialize;

        [NativeTypeName("HRESULT (D2D1_CHANGE_TYPE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_CHANGE_TYPE, int> PrepareForRender;

        [NativeTypeName("HRESULT (ID2D1TransformGraph *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1TransformGraph*, int> SetGraph;
    }
}
