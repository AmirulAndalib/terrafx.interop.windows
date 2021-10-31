// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("3050F683-98B5-11CF-BB82-00AA00BDCE0B")]
    [NativeTypeName("struct ISegment : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISegment
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISegment*, Guid*, void**, int>)(lpVtbl[0]))((ISegment*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISegment*, uint>)(lpVtbl[1]))((ISegment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISegment*, uint>)(lpVtbl[2]))((ISegment*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPointers(IMarkupPointer* pIStart, IMarkupPointer* pIEnd)
        {
            return ((delegate* unmanaged<ISegment*, IMarkupPointer*, IMarkupPointer*, int>)(lpVtbl[3]))((ISegment*)Unsafe.AsPointer(ref this), pIStart, pIEnd);
        }
    }
}
