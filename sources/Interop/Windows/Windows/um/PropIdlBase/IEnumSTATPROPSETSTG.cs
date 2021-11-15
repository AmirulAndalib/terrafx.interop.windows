// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("0000013B-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IEnumSTATPROPSETSTG : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IEnumSTATPROPSETSTG : IEnumSTATPROPSETSTG.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, Guid*, void**, int>)(lpVtbl[0]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, uint>)(lpVtbl[1]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, uint>)(lpVtbl[2]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT Next([NativeTypeName("ULONG")] uint celt, STATPROPSETSTG* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched)
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, uint, STATPROPSETSTG*, uint*, int>)(lpVtbl[3]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this), celt, rgelt, pceltFetched);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT Skip([NativeTypeName("ULONG")] uint celt)
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, uint, int>)(lpVtbl[4]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this), celt);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT Reset()
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, int>)(lpVtbl[5]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT Clone(IEnumSTATPROPSETSTG** ppenum)
        {
            return ((delegate* unmanaged<IEnumSTATPROPSETSTG*, IEnumSTATPROPSETSTG**, int>)(lpVtbl[6]))((IEnumSTATPROPSETSTG*)Unsafe.AsPointer(ref this), ppenum);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT Next([NativeTypeName("ULONG")] uint celt, STATPROPSETSTG* rgelt, [NativeTypeName("ULONG *")] uint* pceltFetched);

            [VtblIndex(4)]
            HRESULT Skip([NativeTypeName("ULONG")] uint celt);

            [VtblIndex(5)]
            HRESULT Reset();

            [VtblIndex(6)]
            HRESULT Clone(IEnumSTATPROPSETSTG** ppenum);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSTATPROPSETSTG*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSTATPROPSETSTG*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSTATPROPSETSTG*, uint> Release;

            [NativeTypeName("HRESULT (ULONG, STATPROPSETSTG *, ULONG *) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSTATPROPSETSTG*, uint, STATPROPSETSTG*, uint*, int> Next;

            [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSTATPROPSETSTG*, uint, int> Skip;

            [NativeTypeName("HRESULT () __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSTATPROPSETSTG*, int> Reset;

            [NativeTypeName("HRESULT (IEnumSTATPROPSETSTG **) __attribute__((stdcall))")]
            public delegate* unmanaged<IEnumSTATPROPSETSTG*, IEnumSTATPROPSETSTG**, int> Clone;
        }
    }
}