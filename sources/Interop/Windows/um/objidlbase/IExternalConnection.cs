// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000019-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IExternalConnection : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IExternalConnection
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IExternalConnection*, Guid*, void**, int>)(lpVtbl[0]))((IExternalConnection*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IExternalConnection*, uint>)(lpVtbl[1]))((IExternalConnection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IExternalConnection*, uint>)(lpVtbl[2]))((IExternalConnection*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        public uint AddConnection([NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved)
        {
            return ((delegate* unmanaged<IExternalConnection*, uint, uint, uint>)(lpVtbl[3]))((IExternalConnection*)Unsafe.AsPointer(ref this), extconn, reserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("DWORD")]
        public uint ReleaseConnection([NativeTypeName("DWORD")] uint extconn, [NativeTypeName("DWORD")] uint reserved, BOOL fLastReleaseCloses)
        {
            return ((delegate* unmanaged<IExternalConnection*, uint, uint, BOOL, uint>)(lpVtbl[4]))((IExternalConnection*)Unsafe.AsPointer(ref this), extconn, reserved, fLastReleaseCloses);
        }
    }
}
