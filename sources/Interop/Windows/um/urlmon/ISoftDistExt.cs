// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B15B8DC1-C7E1-11D0-8680-00AA00BDCB71")]
    [NativeTypeName("struct ISoftDistExt : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISoftDistExt
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISoftDistExt*, Guid*, void**, int>)(lpVtbl[0]))((ISoftDistExt*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISoftDistExt*, uint>)(lpVtbl[1]))((ISoftDistExt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISoftDistExt*, uint>)(lpVtbl[2]))((ISoftDistExt*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ProcessSoftDist([NativeTypeName("LPCWSTR")] ushort* szCDFURL, IXMLElement* pSoftDistElement, [NativeTypeName("LPSOFTDISTINFO")] SOFTDISTINFO* lpsdi)
        {
            return ((delegate* unmanaged<ISoftDistExt*, ushort*, IXMLElement*, SOFTDISTINFO*, int>)(lpVtbl[3]))((ISoftDistExt*)Unsafe.AsPointer(ref this), szCDFURL, pSoftDistElement, lpsdi);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetFirstCodeBase([NativeTypeName("LPWSTR *")] ushort** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize)
        {
            return ((delegate* unmanaged<ISoftDistExt*, ushort**, uint*, int>)(lpVtbl[4]))((ISoftDistExt*)Unsafe.AsPointer(ref this), szCodeBase, dwMaxSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetNextCodeBase([NativeTypeName("LPWSTR *")] ushort** szCodeBase, [NativeTypeName("LPDWORD")] uint* dwMaxSize)
        {
            return ((delegate* unmanaged<ISoftDistExt*, ushort**, uint*, int>)(lpVtbl[5]))((ISoftDistExt*)Unsafe.AsPointer(ref this), szCodeBase, dwMaxSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT AsyncInstallDistributionUnit(IBindCtx* pbc, [NativeTypeName("LPVOID")] void* pvReserved, [NativeTypeName("DWORD")] uint flags, [NativeTypeName("LPCODEBASEHOLD")] CODEBASEHOLD* lpcbh)
        {
            return ((delegate* unmanaged<ISoftDistExt*, IBindCtx*, void*, uint, CODEBASEHOLD*, int>)(lpVtbl[6]))((ISoftDistExt*)Unsafe.AsPointer(ref this), pbc, pvReserved, flags, lpcbh);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftDistExt*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftDistExt*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftDistExt*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, IXMLElement *, LPSOFTDISTINFO) __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftDistExt*, ushort*, IXMLElement*, SOFTDISTINFO*, int> ProcessSoftDist;

            [NativeTypeName("HRESULT (LPWSTR *, LPDWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftDistExt*, ushort**, uint*, int> GetFirstCodeBase;

            [NativeTypeName("HRESULT (LPWSTR *, LPDWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftDistExt*, ushort**, uint*, int> GetNextCodeBase;

            [NativeTypeName("HRESULT (IBindCtx *, LPVOID, DWORD, LPCODEBASEHOLD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISoftDistExt*, IBindCtx*, void*, uint, CODEBASEHOLD*, int> AsyncInstallDistributionUnit;
        }
    }
}
