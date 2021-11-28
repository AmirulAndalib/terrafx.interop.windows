// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[Guid("3787614F-65F7-4003-B673-EAD8293A0E60")]
[NativeTypeName("struct IMFMediaEngineClassFactory3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaEngineClassFactory3 : IMFMediaEngineClassFactory3.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory3*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineClassFactory3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory3*, uint>)(lpVtbl[1]))((IMFMediaEngineClassFactory3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory3*, uint>)(lpVtbl[2]))((IMFMediaEngineClassFactory3*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateMediaKeySystemAccess([NativeTypeName("BSTR")] ushort* keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess)
    {
        return ((delegate* unmanaged<IMFMediaEngineClassFactory3*, ushort*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int>)(lpVtbl[3]))((IMFMediaEngineClassFactory3*)Unsafe.AsPointer(ref this), keySystem, ppSupportedConfigurationsArray, uSize, ppKeyAccess);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateMediaKeySystemAccess([NativeTypeName("BSTR")] ushort* keySystem, IPropertyStore** ppSupportedConfigurationsArray, uint uSize, IMFMediaKeySystemAccess** ppKeyAccess);
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

        [NativeTypeName("HRESULT (BSTR, IPropertyStore **, UINT, IMFMediaKeySystemAccess **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IPropertyStore**, uint, IMFMediaKeySystemAccess**, int> CreateMediaKeySystemAccess;
    }
}
