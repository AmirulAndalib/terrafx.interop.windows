// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8389D2D0-77D7-11D1-ABE6-00A0C905F375")]
    public unsafe partial struct IAMResourceControl
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IAMResourceControl*, Guid*, void**, int>)(lpVtbl[0]))((IAMResourceControl*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IAMResourceControl*, uint>)(lpVtbl[1]))((IAMResourceControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IAMResourceControl*, uint>)(lpVtbl[2]))((IAMResourceControl*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int Reserve([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("PVOID")] void* pvReserved)
        {
            return ((delegate* stdcall<IAMResourceControl*, uint, void*, int>)(lpVtbl[3]))((IAMResourceControl*)Unsafe.AsPointer(ref this), dwFlags, pvReserved);
        }
    }
}