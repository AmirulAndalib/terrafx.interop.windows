// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IWriteEngine2EventArgs.xml' path='doc/member[@name="IWriteEngine2EventArgs"]/*' />
[Guid("27354136-7F64-5B0F-8F00-5D77AFBE261E")]
[NativeTypeName("struct IWriteEngine2EventArgs : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IWriteEngine2EventArgs : IWriteEngine2EventArgs.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, Guid*, void**, int>)(lpVtbl[0]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, uint>)(lpVtbl[1]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, uint>)(lpVtbl[2]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, uint*, int>)(lpVtbl[3]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IWriteEngine2EventArgs.xml' path='doc/member[@name="IWriteEngine2EventArgs.get_StartLba"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_StartLba([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[7]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWriteEngine2EventArgs.xml' path='doc/member[@name="IWriteEngine2EventArgs.get_SectorCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SectorCount([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[8]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWriteEngine2EventArgs.xml' path='doc/member[@name="IWriteEngine2EventArgs.get_LastReadLba"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_LastReadLba([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[9]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWriteEngine2EventArgs.xml' path='doc/member[@name="IWriteEngine2EventArgs.get_LastWrittenLba"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_LastWrittenLba([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[10]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWriteEngine2EventArgs.xml' path='doc/member[@name="IWriteEngine2EventArgs.get_TotalSystemBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_TotalSystemBuffer([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[11]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWriteEngine2EventArgs.xml' path='doc/member[@name="IWriteEngine2EventArgs.get_UsedSystemBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_UsedSystemBuffer([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[12]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IWriteEngine2EventArgs.xml' path='doc/member[@name="IWriteEngine2EventArgs.get_FreeSystemBuffer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_FreeSystemBuffer([NativeTypeName("LONG *")] int* value)
    {
        return ((delegate* unmanaged<IWriteEngine2EventArgs*, int*, int>)(lpVtbl[13]))((IWriteEngine2EventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_StartLba([NativeTypeName("LONG *")] int* value);

        [VtblIndex(8)]
        HRESULT get_SectorCount([NativeTypeName("LONG *")] int* value);

        [VtblIndex(9)]
        HRESULT get_LastReadLba([NativeTypeName("LONG *")] int* value);

        [VtblIndex(10)]
        HRESULT get_LastWrittenLba([NativeTypeName("LONG *")] int* value);

        [VtblIndex(11)]
        HRESULT get_TotalSystemBuffer([NativeTypeName("LONG *")] int* value);

        [VtblIndex(12)]
        HRESULT get_UsedSystemBuffer([NativeTypeName("LONG *")] int* value);

        [VtblIndex(13)]
        HRESULT get_FreeSystemBuffer([NativeTypeName("LONG *")] int* value);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_StartLba;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_SectorCount;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastReadLba;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_LastWrittenLba;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_TotalSystemBuffer;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_UsedSystemBuffer;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_FreeSystemBuffer;
    }
}
