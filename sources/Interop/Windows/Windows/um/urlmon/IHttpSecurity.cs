// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("79EAC9D7-BAFA-11CE-8C82-00AA004BA90B")]
    [NativeTypeName("struct IHttpSecurity : IWindowForBindingUI")]
    [NativeInheritance("IWindowForBindingUI")]
    public unsafe partial struct IHttpSecurity : IHttpSecurity.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHttpSecurity*, Guid*, void**, int>)(lpVtbl[0]))((IHttpSecurity*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHttpSecurity*, uint>)(lpVtbl[1]))((IHttpSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHttpSecurity*, uint>)(lpVtbl[2]))((IHttpSecurity*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, HWND* phwnd)
        {
            return ((delegate* unmanaged<IHttpSecurity*, Guid*, HWND*, int>)(lpVtbl[3]))((IHttpSecurity*)Unsafe.AsPointer(ref this), rguidReason, phwnd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT OnSecurityProblem([NativeTypeName("DWORD")] uint dwProblem)
        {
            return ((delegate* unmanaged<IHttpSecurity*, uint, int>)(lpVtbl[4]))((IHttpSecurity*)Unsafe.AsPointer(ref this), dwProblem);
        }

        public interface Interface : IWindowForBindingUI.Interface
        {
            [VtblIndex(4)]
            HRESULT OnSecurityProblem([NativeTypeName("DWORD")] uint dwProblem);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHttpSecurity*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHttpSecurity*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHttpSecurity*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, HWND *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHttpSecurity*, Guid*, HWND*, int> GetWindow;

            [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IHttpSecurity*, uint, int> OnSecurityProblem;
        }
    }
}