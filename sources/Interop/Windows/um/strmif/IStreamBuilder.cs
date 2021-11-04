// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("56A868BF-0AD4-11CE-B03A-0020AF0BA770")]
    [NativeTypeName("struct IStreamBuilder : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IStreamBuilder
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IStreamBuilder*, Guid*, void**, int>)(lpVtbl[0]))((IStreamBuilder*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IStreamBuilder*, uint>)(lpVtbl[1]))((IStreamBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IStreamBuilder*, uint>)(lpVtbl[2]))((IStreamBuilder*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Render(IPin* ppinOut, IGraphBuilder* pGraph)
        {
            return ((delegate* unmanaged<IStreamBuilder*, IPin*, IGraphBuilder*, int>)(lpVtbl[3]))((IStreamBuilder*)Unsafe.AsPointer(ref this), ppinOut, pGraph);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Backout(IPin* ppinOut, IGraphBuilder* pGraph)
        {
            return ((delegate* unmanaged<IStreamBuilder*, IPin*, IGraphBuilder*, int>)(lpVtbl[4]))((IStreamBuilder*)Unsafe.AsPointer(ref this), ppinOut, pGraph);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamBuilder*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamBuilder*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamBuilder*, uint> Release;

            [NativeTypeName("HRESULT (IPin *, IGraphBuilder *) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamBuilder*, IPin*, IGraphBuilder*, int> Render;

            [NativeTypeName("HRESULT (IPin *, IGraphBuilder *) __attribute__((stdcall))")]
            public delegate* unmanaged<IStreamBuilder*, IPin*, IGraphBuilder*, int> Backout;
        }
    }
}
