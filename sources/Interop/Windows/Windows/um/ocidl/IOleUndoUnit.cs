// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IOleUndoUnit.xml' path='doc/member[@name="IOleUndoUnit"]/*' />
[Guid("894AD3B0-EF97-11CE-9BC9-00AA00608E01")]
[NativeTypeName("struct IOleUndoUnit : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleUndoUnit : IOleUndoUnit.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IOleUndoUnit;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleUndoUnit*, Guid*, void**, int>)(lpVtbl[0]))((IOleUndoUnit*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleUndoUnit*, uint>)(lpVtbl[1]))((IOleUndoUnit*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleUndoUnit*, uint>)(lpVtbl[2]))((IOleUndoUnit*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleUndoUnit.xml' path='doc/member[@name="IOleUndoUnit.Do"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Do(IOleUndoManager* pUndoManager)
    {
        return ((delegate* unmanaged<IOleUndoUnit*, IOleUndoManager*, int>)(lpVtbl[3]))((IOleUndoUnit*)Unsafe.AsPointer(ref this), pUndoManager);
    }

    /// <include file='IOleUndoUnit.xml' path='doc/member[@name="IOleUndoUnit.GetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pBstr)
    {
        return ((delegate* unmanaged<IOleUndoUnit*, ushort**, int>)(lpVtbl[4]))((IOleUndoUnit*)Unsafe.AsPointer(ref this), pBstr);
    }

    /// <include file='IOleUndoUnit.xml' path='doc/member[@name="IOleUndoUnit.GetUnitType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetUnitType([NativeTypeName("CLSID *")] Guid* pClsid, [NativeTypeName("LONG *")] int* plID)
    {
        return ((delegate* unmanaged<IOleUndoUnit*, Guid*, int*, int>)(lpVtbl[5]))((IOleUndoUnit*)Unsafe.AsPointer(ref this), pClsid, plID);
    }

    /// <include file='IOleUndoUnit.xml' path='doc/member[@name="IOleUndoUnit.OnNextAdd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnNextAdd()
    {
        return ((delegate* unmanaged<IOleUndoUnit*, int>)(lpVtbl[6]))((IOleUndoUnit*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Do(IOleUndoManager* pUndoManager);

        [VtblIndex(4)]
        HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pBstr);

        [VtblIndex(5)]
        HRESULT GetUnitType([NativeTypeName("CLSID *")] Guid* pClsid, [NativeTypeName("LONG *")] int* plID);

        [VtblIndex(6)]
        HRESULT OnNextAdd();
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

        [NativeTypeName("HRESULT (IOleUndoManager *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IOleUndoManager*, int> Do;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (CLSID *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int*, int> GetUnitType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnNextAdd;
    }
}
