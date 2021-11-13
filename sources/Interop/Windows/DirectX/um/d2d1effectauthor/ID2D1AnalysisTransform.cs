// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX
{
    [Guid("0359DC30-95E6-4568-9055-27720D130E93")]
    [NativeTypeName("struct ID2D1AnalysisTransform : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ID2D1AnalysisTransform : ID2D1AnalysisTransform.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ID2D1AnalysisTransform*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1AnalysisTransform*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ID2D1AnalysisTransform*, uint>)(lpVtbl[1]))((ID2D1AnalysisTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ID2D1AnalysisTransform*, uint>)(lpVtbl[2]))((ID2D1AnalysisTransform*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT ProcessAnalysisResults([NativeTypeName("const BYTE *")] byte* analysisData, [NativeTypeName("UINT32")] uint analysisDataCount)
        {
            return ((delegate* unmanaged<ID2D1AnalysisTransform*, byte*, uint, int>)(lpVtbl[3]))((ID2D1AnalysisTransform*)Unsafe.AsPointer(ref this), analysisData, analysisDataCount);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT ProcessAnalysisResults([NativeTypeName("const BYTE *")] byte* analysisData, [NativeTypeName("UINT32")] uint analysisDataCount);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1AnalysisTransform*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1AnalysisTransform*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1AnalysisTransform*, uint> Release;

            [NativeTypeName("HRESULT (const BYTE *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
            public delegate* unmanaged<ID2D1AnalysisTransform*, byte*, uint, int> ProcessAnalysisResults;
        }
    }
}
