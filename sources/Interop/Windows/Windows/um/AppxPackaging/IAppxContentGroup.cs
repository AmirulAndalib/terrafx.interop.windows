// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='IAppxContentGroup.xml' path='doc/member[@name="IAppxContentGroup"]/*' />
[Guid("328F6468-C04F-4E3C-B6FA-6B8D27F3003A")]
[NativeTypeName("struct IAppxContentGroup : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxContentGroup : IAppxContentGroup.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxContentGroup*, Guid*, void**, int>)(lpVtbl[0]))((IAppxContentGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxContentGroup*, uint>)(lpVtbl[1]))((IAppxContentGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxContentGroup*, uint>)(lpVtbl[2]))((IAppxContentGroup*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxContentGroup.xml' path='doc/member[@name="IAppxContentGroup.GetName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** groupName)
    {
        return ((delegate* unmanaged<IAppxContentGroup*, ushort**, int>)(lpVtbl[3]))((IAppxContentGroup*)Unsafe.AsPointer(ref this), groupName);
    }

    /// <include file='IAppxContentGroup.xml' path='doc/member[@name="IAppxContentGroup.GetFiles"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFiles(IAppxContentGroupFilesEnumerator** enumerator)
    {
        return ((delegate* unmanaged<IAppxContentGroup*, IAppxContentGroupFilesEnumerator**, int>)(lpVtbl[4]))((IAppxContentGroup*)Unsafe.AsPointer(ref this), enumerator);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetName([NativeTypeName("LPWSTR *")] ushort** groupName);

        [VtblIndex(4)]
        HRESULT GetFiles(IAppxContentGroupFilesEnumerator** enumerator);
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

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;

        [NativeTypeName("HRESULT (IAppxContentGroupFilesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxContentGroupFilesEnumerator**, int> GetFiles;
    }
}
