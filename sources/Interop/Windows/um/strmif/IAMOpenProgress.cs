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
    public unsafe partial struct IAMOpenProgress
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
    }
}
