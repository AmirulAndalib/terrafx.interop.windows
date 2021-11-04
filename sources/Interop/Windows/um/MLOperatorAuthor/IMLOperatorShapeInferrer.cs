// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("540BE5BE-A6C9-40EE-83F6-D2B8B40A7798")]
    [NativeTypeName("struct IMLOperatorShapeInferrer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMLOperatorShapeInferrer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferrer*, Guid*, void**, int>)(lpVtbl[0]))((IMLOperatorShapeInferrer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferrer*, uint>)(lpVtbl[1]))((IMLOperatorShapeInferrer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferrer*, uint>)(lpVtbl[2]))((IMLOperatorShapeInferrer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT InferOutputShapes(IMLOperatorShapeInferenceContext* context)
        {
            return ((delegate* unmanaged<IMLOperatorShapeInferrer*, IMLOperatorShapeInferenceContext*, int>)(lpVtbl[3]))((IMLOperatorShapeInferrer*)Unsafe.AsPointer(ref this), context);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferrer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferrer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferrer*, uint> Release;

            [NativeTypeName("HRESULT (IMLOperatorShapeInferenceContext *) noexcept __attribute__((stdcall))")]
            public delegate* unmanaged<IMLOperatorShapeInferrer*, IMLOperatorShapeInferenceContext*, int> InferOutputShapes;
        }
    }
}
