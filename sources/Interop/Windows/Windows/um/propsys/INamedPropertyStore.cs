// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("71604B0F-97B0-4764-8577-2F13E98A1422")]
    [NativeTypeName("struct INamedPropertyStore : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct INamedPropertyStore : INamedPropertyStore.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<INamedPropertyStore*, Guid*, void**, int>)(lpVtbl[0]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<INamedPropertyStore*, uint>)(lpVtbl[1]))((INamedPropertyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<INamedPropertyStore*, uint>)(lpVtbl[2]))((INamedPropertyStore*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetNamedValue([NativeTypeName("LPCWSTR")] ushort* pszName, PROPVARIANT* ppropvar)
        {
            return ((delegate* unmanaged<INamedPropertyStore*, ushort*, PROPVARIANT*, int>)(lpVtbl[3]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), pszName, ppropvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetNamedValue([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar)
        {
            return ((delegate* unmanaged<INamedPropertyStore*, ushort*, PROPVARIANT*, int>)(lpVtbl[4]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), pszName, propvar);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetNameCount([NativeTypeName("DWORD *")] uint* pdwCount)
        {
            return ((delegate* unmanaged<INamedPropertyStore*, uint*, int>)(lpVtbl[5]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), pdwCount);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetNameAt([NativeTypeName("DWORD")] uint iProp, [NativeTypeName("BSTR *")] ushort** pbstrName)
        {
            return ((delegate* unmanaged<INamedPropertyStore*, uint, ushort**, int>)(lpVtbl[6]))((INamedPropertyStore*)Unsafe.AsPointer(ref this), iProp, pbstrName);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetNamedValue([NativeTypeName("LPCWSTR")] ushort* pszName, PROPVARIANT* ppropvar);

            [VtblIndex(4)]
            HRESULT SetNamedValue([NativeTypeName("LPCWSTR")] ushort* pszName, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);

            [VtblIndex(5)]
            HRESULT GetNameCount([NativeTypeName("DWORD *")] uint* pdwCount);

            [VtblIndex(6)]
            HRESULT GetNameAt([NativeTypeName("DWORD")] uint iProp, [NativeTypeName("BSTR *")] ushort** pbstrName);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyStore*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyStore*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyStore*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyStore*, ushort*, PROPVARIANT*, int> GetNamedValue;

            [NativeTypeName("HRESULT (LPCWSTR, const PROPVARIANT &) __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyStore*, ushort*, PROPVARIANT*, int> SetNamedValue;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyStore*, uint*, int> GetNameCount;

            [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<INamedPropertyStore*, uint, ushort**, int> GetNameAt;
        }
    }
}
