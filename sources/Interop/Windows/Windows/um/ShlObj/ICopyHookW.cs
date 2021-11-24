// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("000214FC-0000-0000-C000-000000000046")]
[NativeTypeName("struct ICopyHookW : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICopyHookW : ICopyHookW.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICopyHookW*, Guid*, void**, int>)(lpVtbl[0]))((ICopyHookW*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICopyHookW*, uint>)(lpVtbl[1]))((ICopyHookW*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICopyHookW*, uint>)(lpVtbl[2]))((ICopyHookW*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public uint CopyCallback(HWND hwnd, uint wFunc, uint wFlags, [NativeTypeName("PCWSTR")] ushort* pszSrcFile, [NativeTypeName("DWORD")] uint dwSrcAttribs, [NativeTypeName("PCWSTR")] ushort* pszDestFile, [NativeTypeName("DWORD")] uint dwDestAttribs)
    {
        return ((delegate* unmanaged<ICopyHookW*, HWND, uint, uint, ushort*, uint, ushort*, uint, uint>)(lpVtbl[3]))((ICopyHookW*)Unsafe.AsPointer(ref this), hwnd, wFunc, wFlags, pszSrcFile, dwSrcAttribs, pszDestFile, dwDestAttribs);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        uint CopyCallback(HWND hwnd, uint wFunc, uint wFlags, [NativeTypeName("PCWSTR")] ushort* pszSrcFile, [NativeTypeName("DWORD")] uint dwSrcAttribs, [NativeTypeName("PCWSTR")] ushort* pszDestFile, [NativeTypeName("DWORD")] uint dwDestAttribs);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ICopyHookW*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ICopyHookW*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ICopyHookW*, uint> Release;

        [NativeTypeName("UINT (HWND, UINT, UINT, PCWSTR, DWORD, PCWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<ICopyHookW*, HWND, uint, uint, ushort*, uint, ushort*, uint, uint> CopyCallback;
    }
}
