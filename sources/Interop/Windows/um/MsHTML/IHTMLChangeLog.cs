// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F649-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct IHTMLChangeLog : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IHTMLChangeLog
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IHTMLChangeLog*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLChangeLog*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IHTMLChangeLog*, uint>)(lpVtbl[1]))((IHTMLChangeLog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IHTMLChangeLog*, uint>)(lpVtbl[2]))((IHTMLChangeLog*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetNextChange(byte* pbBuffer, [NativeTypeName("long")] int nBufferSize, [NativeTypeName("long *")] int* pnRecordLength)
        {
            return ((delegate* unmanaged<IHTMLChangeLog*, byte*, int, int*, int>)(lpVtbl[3]))((IHTMLChangeLog*)Unsafe.AsPointer(ref this), pbBuffer, nBufferSize, pnRecordLength);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLChangeLog*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLChangeLog*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLChangeLog*, uint> Release;

            [NativeTypeName("HRESULT (BYTE *, long, long *) __attribute__((stdcall))")]
            public delegate* unmanaged<IHTMLChangeLog*, byte*, int, int*, int> GetNextChange;
        }
    }
}
