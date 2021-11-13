// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("DCB821A8-1039-441E-9F1C-B1759C2F3CEC")]
    [NativeTypeName("struct IDMLDispatchable : IDMLPageable")]
    [NativeInheritance("IDMLPageable")]
    public unsafe partial struct IDMLDispatchable : IDMLDispatchable.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMLDispatchable*, Guid*, void**, int>)(lpVtbl[0]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMLDispatchable*, uint>)(lpVtbl[1]))((IDMLDispatchable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDMLDispatchable*, uint>)(lpVtbl[2]))((IDMLDispatchable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data)
        {
            return ((delegate* unmanaged<IDMLDispatchable*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* unmanaged<IDMLDispatchable*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data)
        {
            return ((delegate* unmanaged<IDMLDispatchable*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), guid, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* unmanaged<IDMLDispatchable*, ushort*, int>)(lpVtbl[6]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDispatchable*, Guid*, void**, int>)(lpVtbl[7]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public DML_BINDING_PROPERTIES GetBindingProperties()
        {
            DML_BINDING_PROPERTIES result;
            return *((delegate* unmanaged<IDMLDispatchable*, DML_BINDING_PROPERTIES*, DML_BINDING_PROPERTIES*>)(lpVtbl[8]))((IDMLDispatchable*)Unsafe.AsPointer(ref this), &result);
        }

        public interface Interface : IDMLPageable.Interface
        {
            [VtblIndex(8)]
            DML_BINDING_PROPERTIES GetBindingProperties();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDispatchable*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDispatchable*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDispatchable*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDispatchable*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDispatchable*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDispatchable*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDispatchable*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDispatchable*, Guid*, void**, int> GetDevice;

            [NativeTypeName("DML_BINDING_PROPERTIES () __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDispatchable*, DML_BINDING_PROPERTIES*, DML_BINDING_PROPERTIES*> GetBindingProperties;
        }
    }
}
