// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("71E806FB-8DEE-46FC-BF8C-7748A8A1AE13")]
    [NativeTypeName("struct IObjectWithProgID : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IObjectWithProgID : IObjectWithProgID.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IObjectWithProgID*, Guid*, void**, int>)(lpVtbl[0]))((IObjectWithProgID*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IObjectWithProgID*, uint>)(lpVtbl[1]))((IObjectWithProgID*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IObjectWithProgID*, uint>)(lpVtbl[2]))((IObjectWithProgID*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetProgID([NativeTypeName("LPCWSTR")] ushort* pszProgID)
        {
            return ((delegate* unmanaged<IObjectWithProgID*, ushort*, int>)(lpVtbl[3]))((IObjectWithProgID*)Unsafe.AsPointer(ref this), pszProgID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetProgID([NativeTypeName("LPWSTR *")] ushort** ppszProgID)
        {
            return ((delegate* unmanaged<IObjectWithProgID*, ushort**, int>)(lpVtbl[4]))((IObjectWithProgID*)Unsafe.AsPointer(ref this), ppszProgID);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT SetProgID([NativeTypeName("LPCWSTR")] ushort* pszProgID);

            [VtblIndex(4)]
            HRESULT GetProgID([NativeTypeName("LPWSTR *")] ushort** ppszProgID);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IObjectWithProgID*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IObjectWithProgID*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IObjectWithProgID*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<IObjectWithProgID*, ushort*, int> SetProgID;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IObjectWithProgID*, ushort**, int> GetProgID;
        }
    }
}