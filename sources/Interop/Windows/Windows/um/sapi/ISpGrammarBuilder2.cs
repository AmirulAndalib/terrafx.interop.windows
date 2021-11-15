// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows
{
    [Guid("8AB10026-20CC-4B20-8C22-A49C9BA78F60")]
    [NativeTypeName("struct ISpGrammarBuilder2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpGrammarBuilder2 : ISpGrammarBuilder2.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder2*, Guid*, void**, int>)(lpVtbl[0]))((ISpGrammarBuilder2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpGrammarBuilder2*, uint>)(lpVtbl[1]))((ISpGrammarBuilder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpGrammarBuilder2*, uint>)(lpVtbl[2]))((ISpGrammarBuilder2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT AddTextSubset(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, [NativeTypeName("LPCWSTR")] ushort* psz, SPMATCHINGMODE eMatchMode)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder2*, SPSTATEHANDLE, SPSTATEHANDLE, ushort*, SPMATCHINGMODE, int>)(lpVtbl[3]))((ISpGrammarBuilder2*)Unsafe.AsPointer(ref this), hFromState, hToState, psz, eMatchMode);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT SetPhoneticAlphabet(PHONETICALPHABET phoneticALphabet)
        {
            return ((delegate* unmanaged<ISpGrammarBuilder2*, PHONETICALPHABET, int>)(lpVtbl[4]))((ISpGrammarBuilder2*)Unsafe.AsPointer(ref this), phoneticALphabet);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT AddTextSubset(SPSTATEHANDLE hFromState, SPSTATEHANDLE hToState, [NativeTypeName("LPCWSTR")] ushort* psz, SPMATCHINGMODE eMatchMode);

            [VtblIndex(4)]
            HRESULT SetPhoneticAlphabet(PHONETICALPHABET phoneticALphabet);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder2*, uint> Release;

            [NativeTypeName("HRESULT (SPSTATEHANDLE, SPSTATEHANDLE, LPCWSTR, SPMATCHINGMODE) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder2*, SPSTATEHANDLE, SPSTATEHANDLE, ushort*, SPMATCHINGMODE, int> AddTextSubset;

            [NativeTypeName("HRESULT (PHONETICALPHABET) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpGrammarBuilder2*, PHONETICALPHABET, int> SetPhoneticAlphabet;
        }
    }
}