// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("CF7B26FC-9A00-485B-8147-3E789D5E8F67")]
    [NativeTypeName("struct IAMAsyncReaderTimestampScaling : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMAsyncReaderTimestampScaling
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, Guid*, void**, int>)(lpVtbl[0]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, uint>)(lpVtbl[1]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, uint>)(lpVtbl[2]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetTimestampMode(BOOL* pfRaw)
        {
            return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, BOOL*, int>)(lpVtbl[3]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this), pfRaw);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetTimestampMode(BOOL fRaw)
        {
            return ((delegate* unmanaged<IAMAsyncReaderTimestampScaling*, BOOL, int>)(lpVtbl[4]))((IAMAsyncReaderTimestampScaling*)Unsafe.AsPointer(ref this), fRaw);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMAsyncReaderTimestampScaling*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMAsyncReaderTimestampScaling*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMAsyncReaderTimestampScaling*, uint> Release;

            [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMAsyncReaderTimestampScaling*, BOOL*, int> GetTimestampMode;

            [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMAsyncReaderTimestampScaling*, BOOL, int> SetTimestampMode;
        }
    }
}
