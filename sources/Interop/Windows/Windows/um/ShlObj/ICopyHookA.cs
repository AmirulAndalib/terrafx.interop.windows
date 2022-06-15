// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ICopyHookA.xml' path='doc/member[@name="ICopyHookA"]/*' />
[Guid("000214EF-0000-0000-C000-000000000046")]
[NativeTypeName("struct ICopyHookA : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICopyHookA : ICopyHookA.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_ICopyHookA;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICopyHookA*, Guid*, void**, int>)(lpVtbl[0]))((ICopyHookA*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICopyHookA*, uint>)(lpVtbl[1]))((ICopyHookA*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICopyHookA*, uint>)(lpVtbl[2]))((ICopyHookA*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICopyHookA.xml' path='doc/member[@name="ICopyHookA.CopyCallback"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public uint CopyCallback(HWND hwnd, uint wFunc, uint wFlags, [NativeTypeName("PCSTR")] sbyte* pszSrcFile, [NativeTypeName("DWORD")] uint dwSrcAttribs, [NativeTypeName("PCSTR")] sbyte* pszDestFile, [NativeTypeName("DWORD")] uint dwDestAttribs)
    {
        return ((delegate* unmanaged<ICopyHookA*, HWND, uint, uint, sbyte*, uint, sbyte*, uint, uint>)(lpVtbl[3]))((ICopyHookA*)Unsafe.AsPointer(ref this), hwnd, wFunc, wFlags, pszSrcFile, dwSrcAttribs, pszDestFile, dwDestAttribs);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        uint CopyCallback(HWND hwnd, uint wFunc, uint wFlags, [NativeTypeName("PCSTR")] sbyte* pszSrcFile, [NativeTypeName("DWORD")] uint dwSrcAttribs, [NativeTypeName("PCSTR")] sbyte* pszDestFile, [NativeTypeName("DWORD")] uint dwDestAttribs);
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

        [NativeTypeName("UINT (HWND, UINT, UINT, PCSTR, DWORD, PCSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, uint, sbyte*, uint, sbyte*, uint, uint> CopyCallback;
    }
}
