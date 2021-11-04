// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("01C2D285-D3C7-4B7B-B5B5-D97411D0C283")]
    [NativeTypeName("struct ITfLangBarItemBalloon : ITfLangBarItem")]
    [NativeInheritance("ITfLangBarItem")]
    public unsafe partial struct ITfLangBarItemBalloon
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, uint>)(lpVtbl[1]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, uint>)(lpVtbl[2]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetInfo(TF_LANGBARITEMINFO* pInfo)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, TF_LANGBARITEMINFO*, int>)(lpVtbl[3]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), pInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetStatus([NativeTypeName("DWORD *")] uint* pdwStatus)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, uint*, int>)(lpVtbl[4]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), pdwStatus);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Show(BOOL fShow)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, BOOL, int>)(lpVtbl[5]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), fShow);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetTooltipString([NativeTypeName("BSTR *")] ushort** pbstrToolTip)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, ushort**, int>)(lpVtbl[6]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), pbstrToolTip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT OnClick(TfLBIClick click, POINT pt, [NativeTypeName("const RECT *")] RECT* prcArea)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, TfLBIClick, POINT, RECT*, int>)(lpVtbl[7]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), click, pt, prcArea);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetPreferredSize([NativeTypeName("const SIZE *")] SIZE* pszDefault, SIZE* psz)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, SIZE*, SIZE*, int>)(lpVtbl[8]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), pszDefault, psz);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetBalloonInfo(TF_LBBALLOONINFO* pInfo)
        {
            return ((delegate* unmanaged<ITfLangBarItemBalloon*, TF_LBBALLOONINFO*, int>)(lpVtbl[9]))((ITfLangBarItemBalloon*)Unsafe.AsPointer(ref this), pInfo);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemBalloon*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemBalloon*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemBalloon*, uint> Release;

            [NativeTypeName("HRESULT (TF_LANGBARITEMINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemBalloon*, TF_LANGBARITEMINFO*, int> GetInfo;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemBalloon*, uint*, int> GetStatus;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemBalloon*, BOOL, int> Show;

            [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemBalloon*, ushort**, int> GetTooltipString;

            [NativeTypeName("HRESULT (TfLBIClick, POINT, const RECT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemBalloon*, TfLBIClick, POINT, RECT*, int> OnClick;

            [NativeTypeName("HRESULT (const SIZE *, SIZE *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemBalloon*, SIZE*, SIZE*, int> GetPreferredSize;

            [NativeTypeName("HRESULT (TF_LBBALLOONINFO *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarItemBalloon*, TF_LBBALLOONINFO*, int> GetBalloonInfo;
        }
    }
}
