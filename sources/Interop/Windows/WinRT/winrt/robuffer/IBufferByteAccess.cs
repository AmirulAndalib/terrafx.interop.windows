// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/robuffer.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT
{
    [Guid("905A0FEF-BC53-11DF-8C49-001E4FC686DA")]
    [NativeTypeName("struct IBufferByteAccess : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IBufferByteAccess : IBufferByteAccess.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IBufferByteAccess*, Guid*, void**, int>)(lpVtbl[0]))((IBufferByteAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IBufferByteAccess*, uint>)(lpVtbl[1]))((IBufferByteAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IBufferByteAccess*, uint>)(lpVtbl[2]))((IBufferByteAccess*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Buffer(byte** value)
        {
            return ((delegate* unmanaged<IBufferByteAccess*, byte**, int>)(lpVtbl[3]))((IBufferByteAccess*)Unsafe.AsPointer(ref this), value);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Buffer(byte** value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IBufferByteAccess*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBufferByteAccess*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IBufferByteAccess*, uint> Release;

            [NativeTypeName("HRESULT (byte **) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<IBufferByteAccess*, byte**, int> Buffer;
        }
    }
}
