// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("FBE256C1-43CF-4A9B-8CB8-CE8632A34186")]
    [NativeTypeName("struct IMFMediaEngineClassFactory4 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFMediaEngineClassFactory4 : IMFMediaEngineClassFactory4.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineClassFactory4*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaEngineClassFactory4*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFMediaEngineClassFactory4*, uint>)(lpVtbl[1]))((IMFMediaEngineClassFactory4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFMediaEngineClassFactory4*, uint>)(lpVtbl[2]))((IMFMediaEngineClassFactory4*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateContentDecryptionModuleFactory([NativeTypeName("LPCWSTR")] ushort* keySystem, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFMediaEngineClassFactory4*, ushort*, Guid*, void**, int>)(lpVtbl[3]))((IMFMediaEngineClassFactory4*)Unsafe.AsPointer(ref this), keySystem, riid, ppvObject);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateContentDecryptionModuleFactory([NativeTypeName("LPCWSTR")] ushort* keySystem, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineClassFactory4*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineClassFactory4*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineClassFactory4*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, const IID &, LPVOID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IMFMediaEngineClassFactory4*, ushort*, Guid*, void**, int> CreateContentDecryptionModuleFactory;
        }
    }
}