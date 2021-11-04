// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("87955690-E627-11D2-8DDB-00105A2799B5")]
    [NativeTypeName("struct ITfLangBarMgr : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ITfLangBarMgr
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint>)(lpVtbl[1]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint>)(lpVtbl[2]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AdviseEventSink(ITfLangBarEventSink* pSink, HWND hwnd, [NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwCookie)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, ITfLangBarEventSink*, HWND, uint, uint*, int>)(lpVtbl[3]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), pSink, hwnd, dwFlags, pdwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT UnadviseEventSink([NativeTypeName("DWORD")] uint dwCookie)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint, int>)(lpVtbl[4]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwCookie);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetThreadMarshalInterface([NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("DWORD")] uint dwType, [NativeTypeName("const IID &")] Guid* riid, IUnknown** ppunk)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint, uint, Guid*, IUnknown**, int>)(lpVtbl[5]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwThreadId, dwType, riid, ppunk);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetThreadLangBarItemMgr([NativeTypeName("DWORD")] uint dwThreadId, ITfLangBarItemMgr** pplbi, [NativeTypeName("DWORD *")] uint* pdwThreadid)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint, ITfLangBarItemMgr**, uint*, int>)(lpVtbl[6]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwThreadId, pplbi, pdwThreadid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetInputProcessorProfiles([NativeTypeName("DWORD")] uint dwThreadId, ITfInputProcessorProfiles** ppaip, [NativeTypeName("DWORD *")] uint* pdwThreadid)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint, ITfInputProcessorProfiles**, uint*, int>)(lpVtbl[7]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwThreadId, ppaip, pdwThreadid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT RestoreLastFocus([NativeTypeName("DWORD *")] uint* pdwThreadId, BOOL fPrev)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint*, BOOL, int>)(lpVtbl[8]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), pdwThreadId, fPrev);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetModalInput(ITfLangBarEventSink* pSink, [NativeTypeName("DWORD")] uint dwThreadId, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, ITfLangBarEventSink*, uint, uint, int>)(lpVtbl[9]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), pSink, dwThreadId, dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT ShowFloating([NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint, int>)(lpVtbl[10]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), dwFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HRESULT GetShowFloatingStatus([NativeTypeName("DWORD *")] uint* pdwFlags)
        {
            return ((delegate* unmanaged<ITfLangBarMgr*, uint*, int>)(lpVtbl[11]))((ITfLangBarMgr*)Unsafe.AsPointer(ref this), pdwFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarMgr*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarMgr*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarMgr*, uint> Release;

            [NativeTypeName("HRESULT (ITfLangBarEventSink *, HWND, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarMgr*, ITfLangBarEventSink*, HWND, uint, uint*, int> AdviseEventSink;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarMgr*, uint, int> UnadviseEventSink;

            [NativeTypeName("HRESULT (DWORD, DWORD, const IID &, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarMgr*, uint, uint, Guid*, IUnknown**, int> GetThreadMarshalInterface;

            [NativeTypeName("HRESULT (DWORD, ITfLangBarItemMgr **, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarMgr*, uint, ITfLangBarItemMgr**, uint*, int> GetThreadLangBarItemMgr;

            [NativeTypeName("HRESULT (DWORD, ITfInputProcessorProfiles **, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarMgr*, uint, ITfInputProcessorProfiles**, uint*, int> GetInputProcessorProfiles;

            [NativeTypeName("HRESULT (DWORD *, BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarMgr*, uint*, BOOL, int> RestoreLastFocus;

            [NativeTypeName("HRESULT (ITfLangBarEventSink *, DWORD, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarMgr*, ITfLangBarEventSink*, uint, uint, int> SetModalInput;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarMgr*, uint, int> ShowFloating;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ITfLangBarMgr*, uint*, int> GetShowFloatingStatus;
        }
    }
}
