// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("27E83142-8165-49E3-974E-2FD66E4CB69D")]
    [NativeTypeName("struct IDMLDeviceChild : IDMLObject")]
    [NativeInheritance("IDMLObject")]
    public unsafe partial struct IDMLDeviceChild : IDMLDeviceChild.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDMLDeviceChild*, Guid*, void**, int>)(lpVtbl[0]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDMLDeviceChild*, uint>)(lpVtbl[1]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDMLDeviceChild*, uint>)(lpVtbl[2]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* dataSize, void* data)
        {
            return ((delegate* unmanaged<IDMLDeviceChild*, Guid*, uint*, void*, int>)(lpVtbl[3]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint dataSize, [NativeTypeName("const void *")] void* data)
        {
            return ((delegate* unmanaged<IDMLDeviceChild*, Guid*, uint, void*, int>)(lpVtbl[4]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), guid, dataSize, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, IUnknown* data)
        {
            return ((delegate* unmanaged<IDMLDeviceChild*, Guid*, IUnknown*, int>)(lpVtbl[5]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), guid, data);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetName([NativeTypeName("PCWSTR")] ushort* name)
        {
            return ((delegate* unmanaged<IDMLDeviceChild*, ushort*, int>)(lpVtbl[6]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), name);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IDMLDeviceChild*, Guid*, void**, int>)(lpVtbl[7]))((IDMLDeviceChild*)Unsafe.AsPointer(ref this), riid, ppv);
        }

        public interface Interface : IDMLObject.Interface
        {
            [VtblIndex(7)]
            HRESULT GetDevice([NativeTypeName("const IID &")] Guid* riid, void** ppv);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDeviceChild*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDeviceChild*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDeviceChild*, uint> Release;

            [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDeviceChild*, Guid*, uint*, void*, int> GetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDeviceChild*, Guid*, uint, void*, int> SetPrivateData;

            [NativeTypeName("HRESULT (const GUID &, IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDeviceChild*, Guid*, IUnknown*, int> SetPrivateDataInterface;

            [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDeviceChild*, ushort*, int> SetName;

            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IDMLDeviceChild*, Guid*, void**, int> GetDevice;
        }
    }
}
