// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("4B37BC9E-9ED6-44A3-93D3-18F022B79EC3")]
    [NativeTypeName("struct ISpRecoGrammar2 : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpRecoGrammar2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpRecoGrammar2*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpRecoGrammar2*, uint>)(lpVtbl[1]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpRecoGrammar2*, uint>)(lpVtbl[2]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetRules(SPRULE** ppCoMemRules, uint* puNumRules)
        {
            return ((delegate* unmanaged<ISpRecoGrammar2*, SPRULE**, uint*, int>)(lpVtbl[3]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), ppCoMemRules, puNumRules);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT LoadCmdFromFile2([NativeTypeName("LPCWSTR")] ushort* pszFileName, SPLOADOPTIONS Options, [NativeTypeName("LPCWSTR")] ushort* pszSharingUri, [NativeTypeName("LPCWSTR")] ushort* pszBaseUri)
        {
            return ((delegate* unmanaged<ISpRecoGrammar2*, ushort*, SPLOADOPTIONS, ushort*, ushort*, int>)(lpVtbl[4]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pszFileName, Options, pszSharingUri, pszBaseUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT LoadCmdFromMemory2([NativeTypeName("const SPBINARYGRAMMAR *")] SPBINARYGRAMMAR* pGrammar, SPLOADOPTIONS Options, [NativeTypeName("LPCWSTR")] ushort* pszSharingUri, [NativeTypeName("LPCWSTR")] ushort* pszBaseUri)
        {
            return ((delegate* unmanaged<ISpRecoGrammar2*, SPBINARYGRAMMAR*, SPLOADOPTIONS, ushort*, ushort*, int>)(lpVtbl[5]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pGrammar, Options, pszSharingUri, pszBaseUri);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetRulePriority([NativeTypeName("LPCWSTR")] ushort* pszRuleName, [NativeTypeName("ULONG")] uint ulRuleId, int nRulePriority)
        {
            return ((delegate* unmanaged<ISpRecoGrammar2*, ushort*, uint, int, int>)(lpVtbl[6]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pszRuleName, ulRuleId, nRulePriority);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT SetRuleWeight([NativeTypeName("LPCWSTR")] ushort* pszRuleName, [NativeTypeName("ULONG")] uint ulRuleId, float flWeight)
        {
            return ((delegate* unmanaged<ISpRecoGrammar2*, ushort*, uint, float, int>)(lpVtbl[7]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pszRuleName, ulRuleId, flWeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetDictationWeight(float flWeight)
        {
            return ((delegate* unmanaged<ISpRecoGrammar2*, float, int>)(lpVtbl[8]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), flWeight);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT SetGrammarLoader(ISpeechResourceLoader* pLoader)
        {
            return ((delegate* unmanaged<ISpRecoGrammar2*, ISpeechResourceLoader*, int>)(lpVtbl[9]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pLoader);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT SetSMLSecurityManager(IInternetSecurityManager* pSMLSecurityManager)
        {
            return ((delegate* unmanaged<ISpRecoGrammar2*, IInternetSecurityManager*, int>)(lpVtbl[10]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pSMLSecurityManager);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoGrammar2*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoGrammar2*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoGrammar2*, uint> Release;

            [NativeTypeName("HRESULT (SPRULE **, UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoGrammar2*, SPRULE**, uint*, int> GetRules;

            [NativeTypeName("HRESULT (LPCWSTR, SPLOADOPTIONS, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoGrammar2*, ushort*, SPLOADOPTIONS, ushort*, ushort*, int> LoadCmdFromFile2;

            [NativeTypeName("HRESULT (const SPBINARYGRAMMAR *, SPLOADOPTIONS, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoGrammar2*, SPBINARYGRAMMAR*, SPLOADOPTIONS, ushort*, ushort*, int> LoadCmdFromMemory2;

            [NativeTypeName("HRESULT (LPCWSTR, ULONG, int) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoGrammar2*, ushort*, uint, int, int> SetRulePriority;

            [NativeTypeName("HRESULT (LPCWSTR, ULONG, float) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoGrammar2*, ushort*, uint, float, int> SetRuleWeight;

            [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoGrammar2*, float, int> SetDictationWeight;

            [NativeTypeName("HRESULT (ISpeechResourceLoader *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoGrammar2*, ISpeechResourceLoader*, int> SetGrammarLoader;

            [NativeTypeName("HRESULT (IInternetSecurityManager *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpRecoGrammar2*, IInternetSecurityManager*, int> SetSMLSecurityManager;
        }
    }
}
