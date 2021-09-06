// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shimgdata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("53FB8E58-50C0-4003-B4AA-0C8DF28E7F3A")]
    [NativeTypeName("struct IShellImageDataAbort : IUnknown")]
    public unsafe partial struct IShellImageDataAbort
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellImageDataAbort*, Guid*, void**, int>)(lpVtbl[0]))((IShellImageDataAbort*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellImageDataAbort*, uint>)(lpVtbl[1]))((IShellImageDataAbort*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellImageDataAbort*, uint>)(lpVtbl[2]))((IShellImageDataAbort*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryAbort()
        {
            return ((delegate* unmanaged<IShellImageDataAbort*, int>)(lpVtbl[3]))((IShellImageDataAbort*)Unsafe.AsPointer(ref this));
        }
    }
}
