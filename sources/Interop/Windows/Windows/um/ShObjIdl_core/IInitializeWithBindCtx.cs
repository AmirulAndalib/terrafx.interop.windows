// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("71C0D2BC-726D-45CC-A6C0-2E31C1DB2159")]
[NativeTypeName("struct IInitializeWithBindCtx : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInitializeWithBindCtx : IInitializeWithBindCtx.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInitializeWithBindCtx*, Guid*, void**, int>)(lpVtbl[0]))((IInitializeWithBindCtx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInitializeWithBindCtx*, uint>)(lpVtbl[1]))((IInitializeWithBindCtx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInitializeWithBindCtx*, uint>)(lpVtbl[2]))((IInitializeWithBindCtx*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(IBindCtx* pbc)
    {
        return ((delegate* unmanaged<IInitializeWithBindCtx*, IBindCtx*, int>)(lpVtbl[3]))((IInitializeWithBindCtx*)Unsafe.AsPointer(ref this), pbc);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(IBindCtx* pbc);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<IInitializeWithBindCtx*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IInitializeWithBindCtx*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<IInitializeWithBindCtx*, uint> Release;

        [NativeTypeName("HRESULT (IBindCtx *) __attribute__((stdcall))")]
        public delegate* unmanaged<IInitializeWithBindCtx*, IBindCtx*, int> Initialize;
    }
}
