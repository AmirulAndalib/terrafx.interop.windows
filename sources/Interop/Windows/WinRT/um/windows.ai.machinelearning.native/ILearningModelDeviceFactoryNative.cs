// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/windows.ai.machinelearning.native.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.DirectX;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    [Guid("1E9B31A1-662E-4AE0-AF67-F63BB337E634")]
    [NativeTypeName("struct ILearningModelDeviceFactoryNative : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ILearningModelDeviceFactoryNative : ILearningModelDeviceFactoryNative.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ILearningModelDeviceFactoryNative*, Guid*, void**, int>)(lpVtbl[0]))((ILearningModelDeviceFactoryNative*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ILearningModelDeviceFactoryNative*, uint>)(lpVtbl[1]))((ILearningModelDeviceFactoryNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ILearningModelDeviceFactoryNative*, uint>)(lpVtbl[2]))((ILearningModelDeviceFactoryNative*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT CreateFromD3D12CommandQueue(ID3D12CommandQueue* value, IUnknown** result)
        {
            return ((delegate* unmanaged<ILearningModelDeviceFactoryNative*, ID3D12CommandQueue*, IUnknown**, int>)(lpVtbl[3]))((ILearningModelDeviceFactoryNative*)Unsafe.AsPointer(ref this), value, result);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT CreateFromD3D12CommandQueue(ID3D12CommandQueue* value, IUnknown** result);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ILearningModelDeviceFactoryNative*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ILearningModelDeviceFactoryNative*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ILearningModelDeviceFactoryNative*, uint> Release;

            [NativeTypeName("HRESULT (ID3D12CommandQueue *, IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<ILearningModelDeviceFactoryNative*, ID3D12CommandQueue*, IUnknown**, int> CreateFromD3D12CommandQueue;
        }
    }
}
