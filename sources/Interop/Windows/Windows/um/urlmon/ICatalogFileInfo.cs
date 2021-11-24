// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("711C7600-6B48-11D1-B403-00AA00B92AF1")]
[NativeTypeName("struct ICatalogFileInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICatalogFileInfo : ICatalogFileInfo.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICatalogFileInfo*, Guid*, void**, int>)(lpVtbl[0]))((ICatalogFileInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICatalogFileInfo*, uint>)(lpVtbl[1]))((ICatalogFileInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICatalogFileInfo*, uint>)(lpVtbl[2]))((ICatalogFileInfo*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCatalogFile([NativeTypeName("LPSTR *")] sbyte** ppszCatalogFile)
    {
        return ((delegate* unmanaged<ICatalogFileInfo*, sbyte**, int>)(lpVtbl[3]))((ICatalogFileInfo*)Unsafe.AsPointer(ref this), ppszCatalogFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetJavaTrust(void** ppJavaTrust)
    {
        return ((delegate* unmanaged<ICatalogFileInfo*, void**, int>)(lpVtbl[4]))((ICatalogFileInfo*)Unsafe.AsPointer(ref this), ppJavaTrust);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCatalogFile([NativeTypeName("LPSTR *")] sbyte** ppszCatalogFile);

        [VtblIndex(4)]
        HRESULT GetJavaTrust(void** ppJavaTrust);
    }

    public partial struct Vtbl
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ICatalogFileInfo*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ICatalogFileInfo*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<ICatalogFileInfo*, uint> Release;

        [NativeTypeName("HRESULT (LPSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<ICatalogFileInfo*, sbyte**, int> GetCatalogFile;

        [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
        public delegate* unmanaged<ICatalogFileInfo*, void**, int> GetJavaTrust;
    }
}
