// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ISpRecoGrammar2.xml' path='doc/member[@name="ISpRecoGrammar2"]/*' />
[Guid("4B37BC9E-9ED6-44A3-93D3-18F022B79EC3")]
[NativeTypeName("struct ISpRecoGrammar2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpRecoGrammar2 : ISpRecoGrammar2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(in IID_ISpRecoGrammar2);

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecoGrammar2*, Guid*, void**, int>)(lpVtbl[0]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecoGrammar2*, uint>)(lpVtbl[1]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecoGrammar2*, uint>)(lpVtbl[2]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpRecoGrammar2.xml' path='doc/member[@name="ISpRecoGrammar2.GetRules"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRules(SPRULE** ppCoMemRules, uint* puNumRules)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecoGrammar2*, SPRULE**, uint*, int>)(lpVtbl[3]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), ppCoMemRules, puNumRules);
    }

    /// <include file='ISpRecoGrammar2.xml' path='doc/member[@name="ISpRecoGrammar2.LoadCmdFromFile2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LoadCmdFromFile2([NativeTypeName("LPCWSTR")] char* pszFileName, SPLOADOPTIONS Options, [NativeTypeName("LPCWSTR")] char* pszSharingUri, [NativeTypeName("LPCWSTR")] char* pszBaseUri)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecoGrammar2*, char*, SPLOADOPTIONS, char*, char*, int>)(lpVtbl[4]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pszFileName, Options, pszSharingUri, pszBaseUri);
    }

    /// <include file='ISpRecoGrammar2.xml' path='doc/member[@name="ISpRecoGrammar2.LoadCmdFromMemory2"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LoadCmdFromMemory2([NativeTypeName("const SPBINARYGRAMMAR *")] SPBINARYGRAMMAR* pGrammar, SPLOADOPTIONS Options, [NativeTypeName("LPCWSTR")] char* pszSharingUri, [NativeTypeName("LPCWSTR")] char* pszBaseUri)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecoGrammar2*, SPBINARYGRAMMAR*, SPLOADOPTIONS, char*, char*, int>)(lpVtbl[5]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pGrammar, Options, pszSharingUri, pszBaseUri);
    }

    /// <include file='ISpRecoGrammar2.xml' path='doc/member[@name="ISpRecoGrammar2.SetRulePriority"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetRulePriority([NativeTypeName("LPCWSTR")] char* pszRuleName, [NativeTypeName("ULONG")] uint ulRuleId, int nRulePriority)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecoGrammar2*, char*, uint, int, int>)(lpVtbl[6]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pszRuleName, ulRuleId, nRulePriority);
    }

    /// <include file='ISpRecoGrammar2.xml' path='doc/member[@name="ISpRecoGrammar2.SetRuleWeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetRuleWeight([NativeTypeName("LPCWSTR")] char* pszRuleName, [NativeTypeName("ULONG")] uint ulRuleId, float flWeight)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecoGrammar2*, char*, uint, float, int>)(lpVtbl[7]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pszRuleName, ulRuleId, flWeight);
    }

    /// <include file='ISpRecoGrammar2.xml' path='doc/member[@name="ISpRecoGrammar2.SetDictationWeight"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetDictationWeight(float flWeight)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecoGrammar2*, float, int>)(lpVtbl[8]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), flWeight);
    }

    /// <include file='ISpRecoGrammar2.xml' path='doc/member[@name="ISpRecoGrammar2.SetGrammarLoader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetGrammarLoader(ISpeechResourceLoader* pLoader)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecoGrammar2*, ISpeechResourceLoader*, int>)(lpVtbl[9]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pLoader);
    }

    /// <include file='ISpRecoGrammar2.xml' path='doc/member[@name="ISpRecoGrammar2.SetSMLSecurityManager"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetSMLSecurityManager(IInternetSecurityManager* pSMLSecurityManager)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpRecoGrammar2*, IInternetSecurityManager*, int>)(lpVtbl[10]))((ISpRecoGrammar2*)Unsafe.AsPointer(ref this), pSMLSecurityManager);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRules(SPRULE** ppCoMemRules, uint* puNumRules);

        [VtblIndex(4)]
        HRESULT LoadCmdFromFile2([NativeTypeName("LPCWSTR")] char* pszFileName, SPLOADOPTIONS Options, [NativeTypeName("LPCWSTR")] char* pszSharingUri, [NativeTypeName("LPCWSTR")] char* pszBaseUri);

        [VtblIndex(5)]
        HRESULT LoadCmdFromMemory2([NativeTypeName("const SPBINARYGRAMMAR *")] SPBINARYGRAMMAR* pGrammar, SPLOADOPTIONS Options, [NativeTypeName("LPCWSTR")] char* pszSharingUri, [NativeTypeName("LPCWSTR")] char* pszBaseUri);

        [VtblIndex(6)]
        HRESULT SetRulePriority([NativeTypeName("LPCWSTR")] char* pszRuleName, [NativeTypeName("ULONG")] uint ulRuleId, int nRulePriority);

        [VtblIndex(7)]
        HRESULT SetRuleWeight([NativeTypeName("LPCWSTR")] char* pszRuleName, [NativeTypeName("ULONG")] uint ulRuleId, float flWeight);

        [VtblIndex(8)]
        HRESULT SetDictationWeight(float flWeight);

        [VtblIndex(9)]
        HRESULT SetGrammarLoader(ISpeechResourceLoader* pLoader);

        [VtblIndex(10)]
        HRESULT SetSMLSecurityManager(IInternetSecurityManager* pSMLSecurityManager);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (SPRULE **, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SPRULE**, uint*, int> GetRules;

        [NativeTypeName("HRESULT (LPCWSTR, SPLOADOPTIONS, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, SPLOADOPTIONS, char*, char*, int> LoadCmdFromFile2;

        [NativeTypeName("HRESULT (const SPBINARYGRAMMAR *, SPLOADOPTIONS, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SPBINARYGRAMMAR*, SPLOADOPTIONS, char*, char*, int> LoadCmdFromMemory2;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG, int) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int, int> SetRulePriority;

        [NativeTypeName("HRESULT (LPCWSTR, ULONG, float) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, float, int> SetRuleWeight;

        [NativeTypeName("HRESULT (float) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> SetDictationWeight;

        [NativeTypeName("HRESULT (ISpeechResourceLoader *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ISpeechResourceLoader*, int> SetGrammarLoader;

        [NativeTypeName("HRESULT (IInternetSecurityManager *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInternetSecurityManager*, int> SetSMLSecurityManager;
    }
}
