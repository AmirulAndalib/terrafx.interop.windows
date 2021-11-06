// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8E1C39A1-DE53-11CF-AA63-0080C744528D")]
    [NativeTypeName("struct IAMOpenProgress : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IAMOpenProgress : IAMOpenProgress.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAMOpenProgress*, Guid*, void**, int>)(lpVtbl[0]))((IAMOpenProgress*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAMOpenProgress*, uint>)(lpVtbl[1]))((IAMOpenProgress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAMOpenProgress*, uint>)(lpVtbl[2]))((IAMOpenProgress*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT QueryProgress([NativeTypeName("LONGLONG *")] long* pllTotal, [NativeTypeName("LONGLONG *")] long* pllCurrent)
        {
            return ((delegate* unmanaged<IAMOpenProgress*, long*, long*, int>)(lpVtbl[3]))((IAMOpenProgress*)Unsafe.AsPointer(ref this), pllTotal, pllCurrent);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AbortOperation()
        {
            return ((delegate* unmanaged<IAMOpenProgress*, int>)(lpVtbl[4]))((IAMOpenProgress*)Unsafe.AsPointer(ref this));
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT QueryProgress([NativeTypeName("LONGLONG *")] long* pllTotal, [NativeTypeName("LONGLONG *")] long* pllCurrent);

            [VtblIndex(4)]
            HRESULT AbortOperation();
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMOpenProgress*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMOpenProgress*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMOpenProgress*, uint> Release;

            [NativeTypeName("HRESULT (LONGLONG *, LONGLONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IAMOpenProgress*, long*, long*, int> QueryProgress;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IAMOpenProgress*, int> AbortOperation;
        }
    }
}
