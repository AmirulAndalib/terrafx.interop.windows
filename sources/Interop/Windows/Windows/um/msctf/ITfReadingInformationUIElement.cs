// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("EA1EA139-19DF-11D7-A6D2-00065B84435C")]
[NativeTypeName("struct ITfReadingInformationUIElement : ITfUIElement")]
[NativeInheritance("ITfUIElement")]
public unsafe partial struct ITfReadingInformationUIElement : ITfReadingInformationUIElement.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, Guid*, void**, int>)(lpVtbl[0]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, uint>)(lpVtbl[1]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, uint>)(lpVtbl[2]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDescription([NativeTypeName("BSTR *")] ushort** pbstrDescription)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, ushort**, int>)(lpVtbl[3]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pbstrDescription);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetGUID(Guid* pguid)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, Guid*, int>)(lpVtbl[4]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pguid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Show(BOOL bShow)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, BOOL, int>)(lpVtbl[5]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), bShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsShown(BOOL* pbShow)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, BOOL*, int>)(lpVtbl[6]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pbShow);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, uint*, int>)(lpVtbl[7]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pdwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetContext(ITfContext** ppic)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, ITfContext**, int>)(lpVtbl[8]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), ppic);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetString([NativeTypeName("BSTR *")] ushort** pstr)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, ushort**, int>)(lpVtbl[9]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pstr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetMaxReadingStringLength(uint* pcchMax)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, uint*, int>)(lpVtbl[10]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pcchMax);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetErrorIndex(uint* pErrorIndex)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, uint*, int>)(lpVtbl[11]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pErrorIndex);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT IsVerticalOrderPreferred(BOOL* pfVertical)
    {
        return ((delegate* unmanaged<ITfReadingInformationUIElement*, BOOL*, int>)(lpVtbl[12]))((ITfReadingInformationUIElement*)Unsafe.AsPointer(ref this), pfVertical);
    }

    public interface Interface : ITfUIElement.Interface
    {
        [VtblIndex(7)]
        HRESULT GetUpdatedFlags([NativeTypeName("DWORD *")] uint* pdwFlags);

        [VtblIndex(8)]
        HRESULT GetContext(ITfContext** ppic);

        [VtblIndex(9)]
        HRESULT GetString([NativeTypeName("BSTR *")] ushort** pstr);

        [VtblIndex(10)]
        HRESULT GetMaxReadingStringLength(uint* pcchMax);

        [VtblIndex(11)]
        HRESULT GetErrorIndex(uint* pErrorIndex);

        [VtblIndex(12)]
        HRESULT IsVerticalOrderPreferred(BOOL* pfVertical);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGUID;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Show;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsShown;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetUpdatedFlags;

        [NativeTypeName("HRESULT (ITfContext **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfContext**, int> GetContext;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetString;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaxReadingStringLength;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetErrorIndex;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsVerticalOrderPreferred;
    }
}
