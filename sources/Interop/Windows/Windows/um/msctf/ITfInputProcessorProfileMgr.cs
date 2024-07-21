// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='ITfInputProcessorProfileMgr.xml' path='doc/member[@name="ITfInputProcessorProfileMgr"]/*' />
[Guid("71C6E74C-0F28-11D8-A82A-00065B84435C")]
[NativeTypeName("struct ITfInputProcessorProfileMgr : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfInputProcessorProfileMgr : ITfInputProcessorProfileMgr.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfInputProcessorProfileMgr));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfInputProcessorProfileMgr*, Guid*, void**, int>)(lpVtbl[0]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ITfInputProcessorProfileMgr*, uint>)(lpVtbl[1]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ITfInputProcessorProfileMgr*, uint>)(lpVtbl[2]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfInputProcessorProfileMgr.xml' path='doc/member[@name="ITfInputProcessorProfileMgr.ActivateProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ActivateProfile([NativeTypeName("DWORD")] uint dwProfileType, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const GUID &")] Guid* guidProfile, HKL hkl, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfInputProcessorProfileMgr*, uint, ushort, Guid*, Guid*, HKL, uint, int>)(lpVtbl[3]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), dwProfileType, langid, clsid, guidProfile, hkl, dwFlags);
    }

    /// <include file='ITfInputProcessorProfileMgr.xml' path='doc/member[@name="ITfInputProcessorProfileMgr.DeactivateProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DeactivateProfile([NativeTypeName("DWORD")] uint dwProfileType, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const GUID &")] Guid* guidProfile, HKL hkl, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfInputProcessorProfileMgr*, uint, ushort, Guid*, Guid*, HKL, uint, int>)(lpVtbl[4]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), dwProfileType, langid, clsid, guidProfile, hkl, dwFlags);
    }

    /// <include file='ITfInputProcessorProfileMgr.xml' path='doc/member[@name="ITfInputProcessorProfileMgr.GetProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetProfile([NativeTypeName("DWORD")] uint dwProfileType, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const GUID &")] Guid* guidProfile, HKL hkl, TF_INPUTPROCESSORPROFILE* pProfile)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfInputProcessorProfileMgr*, uint, ushort, Guid*, Guid*, HKL, TF_INPUTPROCESSORPROFILE*, int>)(lpVtbl[5]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), dwProfileType, langid, clsid, guidProfile, hkl, pProfile);
    }

    /// <include file='ITfInputProcessorProfileMgr.xml' path='doc/member[@name="ITfInputProcessorProfileMgr.EnumProfiles"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumProfiles([NativeTypeName("LANGID")] ushort langid, IEnumTfInputProcessorProfiles** ppEnum)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfInputProcessorProfileMgr*, ushort, IEnumTfInputProcessorProfiles**, int>)(lpVtbl[6]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), langid, ppEnum);
    }

    /// <include file='ITfInputProcessorProfileMgr.xml' path='doc/member[@name="ITfInputProcessorProfileMgr.ReleaseInputProcessor"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReleaseInputProcessor([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfInputProcessorProfileMgr*, Guid*, uint, int>)(lpVtbl[7]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), rclsid, dwFlags);
    }

    /// <include file='ITfInputProcessorProfileMgr.xml' path='doc/member[@name="ITfInputProcessorProfileMgr.RegisterProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RegisterProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("const WCHAR *")] char* pchDesc, [NativeTypeName("ULONG")] uint cchDesc, [NativeTypeName("const WCHAR *")] char* pchIconFile, [NativeTypeName("ULONG")] uint cchFile, [NativeTypeName("ULONG")] uint uIconIndex, HKL hklsubstitute, [NativeTypeName("DWORD")] uint dwPreferredLayout, BOOL bEnabledByDefault, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfInputProcessorProfileMgr*, Guid*, ushort, Guid*, char*, uint, char*, uint, uint, HKL, uint, BOOL, uint, int>)(lpVtbl[8]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, pchDesc, cchDesc, pchIconFile, cchFile, uIconIndex, hklsubstitute, dwPreferredLayout, bEnabledByDefault, dwFlags);
    }

    /// <include file='ITfInputProcessorProfileMgr.xml' path='doc/member[@name="ITfInputProcessorProfileMgr.UnregisterProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT UnregisterProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfInputProcessorProfileMgr*, Guid*, ushort, Guid*, uint, int>)(lpVtbl[9]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), rclsid, langid, guidProfile, dwFlags);
    }

    /// <include file='ITfInputProcessorProfileMgr.xml' path='doc/member[@name="ITfInputProcessorProfileMgr.GetActiveProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetActiveProfile([NativeTypeName("const GUID &")] Guid* catid, TF_INPUTPROCESSORPROFILE* pProfile)
    {
        return ((delegate* unmanaged[MemberFunction]<ITfInputProcessorProfileMgr*, Guid*, TF_INPUTPROCESSORPROFILE*, int>)(lpVtbl[10]))((ITfInputProcessorProfileMgr*)Unsafe.AsPointer(ref this), catid, pProfile);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ActivateProfile([NativeTypeName("DWORD")] uint dwProfileType, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const GUID &")] Guid* guidProfile, HKL hkl, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(4)]
        HRESULT DeactivateProfile([NativeTypeName("DWORD")] uint dwProfileType, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const GUID &")] Guid* guidProfile, HKL hkl, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(5)]
        HRESULT GetProfile([NativeTypeName("DWORD")] uint dwProfileType, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("const GUID &")] Guid* guidProfile, HKL hkl, TF_INPUTPROCESSORPROFILE* pProfile);

        [VtblIndex(6)]
        HRESULT EnumProfiles([NativeTypeName("LANGID")] ushort langid, IEnumTfInputProcessorProfiles** ppEnum);

        [VtblIndex(7)]
        HRESULT ReleaseInputProcessor([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(8)]
        HRESULT RegisterProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("const WCHAR *")] char* pchDesc, [NativeTypeName("ULONG")] uint cchDesc, [NativeTypeName("const WCHAR *")] char* pchIconFile, [NativeTypeName("ULONG")] uint cchFile, [NativeTypeName("ULONG")] uint uIconIndex, HKL hklsubstitute, [NativeTypeName("DWORD")] uint dwPreferredLayout, BOOL bEnabledByDefault, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(9)]
        HRESULT UnregisterProfile([NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("LANGID")] ushort langid, [NativeTypeName("const GUID &")] Guid* guidProfile, [NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(10)]
        HRESULT GetActiveProfile([NativeTypeName("const GUID &")] Guid* catid, TF_INPUTPROCESSORPROFILE* pProfile);
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

        [NativeTypeName("HRESULT (DWORD, LANGID, const IID &, const GUID &, HKL, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ushort, Guid*, Guid*, HKL, uint, int> ActivateProfile;

        [NativeTypeName("HRESULT (DWORD, LANGID, const IID &, const GUID &, HKL, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ushort, Guid*, Guid*, HKL, uint, int> DeactivateProfile;

        [NativeTypeName("HRESULT (DWORD, LANGID, const IID &, const GUID &, HKL, TF_INPUTPROCESSORPROFILE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, ushort, Guid*, Guid*, HKL, TF_INPUTPROCESSORPROFILE*, int> GetProfile;

        [NativeTypeName("HRESULT (LANGID, IEnumTfInputProcessorProfiles **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ushort, IEnumTfInputProcessorProfiles**, int> EnumProfiles;

        [NativeTypeName("HRESULT (const IID &, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, uint, int> ReleaseInputProcessor;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &, const WCHAR *, ULONG, const WCHAR *, ULONG, ULONG, HKL, DWORD, BOOL, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, ushort, Guid*, char*, uint, char*, uint, uint, HKL, uint, BOOL, uint, int> RegisterProfile;

        [NativeTypeName("HRESULT (const IID &, LANGID, const GUID &, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, ushort, Guid*, uint, int> UnregisterProfile;

        [NativeTypeName("HRESULT (const GUID &, TF_INPUTPROCESSORPROFILE *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, TF_INPUTPROCESSORPROFILE*, int> GetActiveProfile;
    }
}
