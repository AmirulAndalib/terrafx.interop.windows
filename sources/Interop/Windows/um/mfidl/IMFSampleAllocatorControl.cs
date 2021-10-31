// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DA62B958-3A38-4A97-BD27-149C640C0771")]
    [NativeTypeName("struct IMFSampleAllocatorControl : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFSampleAllocatorControl
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFSampleAllocatorControl*, Guid*, void**, int>)(lpVtbl[0]))((IMFSampleAllocatorControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFSampleAllocatorControl*, uint>)(lpVtbl[1]))((IMFSampleAllocatorControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFSampleAllocatorControl*, uint>)(lpVtbl[2]))((IMFSampleAllocatorControl*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT SetDefaultAllocator([NativeTypeName("DWORD")] uint dwOutputStreamID, IUnknown* pAllocator)
        {
            return ((delegate* unmanaged<IMFSampleAllocatorControl*, uint, IUnknown*, int>)(lpVtbl[3]))((IMFSampleAllocatorControl*)Unsafe.AsPointer(ref this), dwOutputStreamID, pAllocator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetAllocatorUsage([NativeTypeName("DWORD")] uint dwOutputStreamID, [NativeTypeName("DWORD *")] uint* pdwInputStreamID, MFSampleAllocatorUsage* peUsage)
        {
            return ((delegate* unmanaged<IMFSampleAllocatorControl*, uint, uint*, MFSampleAllocatorUsage*, int>)(lpVtbl[4]))((IMFSampleAllocatorControl*)Unsafe.AsPointer(ref this), dwOutputStreamID, pdwInputStreamID, peUsage);
        }
    }
}
