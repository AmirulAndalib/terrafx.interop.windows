// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B196B284-BAB4-101A-B69C-00AA00341D07")]
    [NativeTypeName("struct IConnectionPointContainer : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IConnectionPointContainer
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IConnectionPointContainer*, Guid*, void**, int>)(lpVtbl[0]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IConnectionPointContainer*, uint>)(lpVtbl[1]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IConnectionPointContainer*, uint>)(lpVtbl[2]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT EnumConnectionPoints(IEnumConnectionPoints** ppEnum)
        {
            return ((delegate* unmanaged<IConnectionPointContainer*, IEnumConnectionPoints**, int>)(lpVtbl[3]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this), ppEnum);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT FindConnectionPoint([NativeTypeName("const IID &")] Guid* riid, IConnectionPoint** ppCP)
        {
            return ((delegate* unmanaged<IConnectionPointContainer*, Guid*, IConnectionPoint**, int>)(lpVtbl[4]))((IConnectionPointContainer*)Unsafe.AsPointer(ref this), riid, ppCP);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPointContainer*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPointContainer*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPointContainer*, uint> Release;

            [NativeTypeName("HRESULT (IEnumConnectionPoints **) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPointContainer*, IEnumConnectionPoints**, int> EnumConnectionPoints;

            [NativeTypeName("HRESULT (const IID &, IConnectionPoint **) __attribute__((stdcall))")]
            public delegate* unmanaged<IConnectionPointContainer*, Guid*, IConnectionPoint**, int> FindConnectionPoint;
        }
    }
}
