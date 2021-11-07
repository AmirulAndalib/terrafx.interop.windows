// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("670D1D20-A068-11D0-B3F0-00AA003761C5")]
    [NativeTypeName("struct IAMCopyCaptureFileProgress : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMCopyCaptureFileProgress : IAMCopyCaptureFileProgress.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMCopyCaptureFileProgress*, Guid*, void**, int>)(lpVtbl[0]))((IAMCopyCaptureFileProgress*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMCopyCaptureFileProgress*, uint>)(lpVtbl[1]))((IAMCopyCaptureFileProgress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMCopyCaptureFileProgress*, uint>)(lpVtbl[2]))((IAMCopyCaptureFileProgress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Progress(int iProgress)
        {
            return ((delegate* unmanaged<IAMCopyCaptureFileProgress*, int, int>)(lpVtbl[3]))((IAMCopyCaptureFileProgress*)Unsafe.AsPointer(ref this), iProgress);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Progress(int iProgress);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMCopyCaptureFileProgress*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMCopyCaptureFileProgress*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMCopyCaptureFileProgress*, uint> Release;

            [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMCopyCaptureFileProgress*, int, int> Progress;
        }
    }
}
