// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFMediaKeys.xml' path='doc/member[@name="IMFMediaKeys"]/*' />
[Guid("5CB31C05-61FF-418F-AFDA-CAAF41421A38")]
[NativeTypeName("struct IMFMediaKeys : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows8.1")]
public unsafe partial struct IMFMediaKeys : IMFMediaKeys.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaKeys));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaKeys*, Guid*, void**, int>)(lpVtbl[0]))((IMFMediaKeys*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFMediaKeys*, uint>)(lpVtbl[1]))((IMFMediaKeys*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaKeys*, uint>)(lpVtbl[2]))((IMFMediaKeys*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaKeys.xml' path='doc/member[@name="IMFMediaKeys.CreateSession"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateSession([NativeTypeName("BSTR")] ushort* mimeType, [NativeTypeName("const BYTE *")] byte* initData, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("const BYTE *")] byte* customData, [NativeTypeName("DWORD")] uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession)
    {
        return ((delegate* unmanaged<IMFMediaKeys*, ushort*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int>)(lpVtbl[3]))((IMFMediaKeys*)Unsafe.AsPointer(ref this), mimeType, initData, cb, customData, cbCustomData, notify, ppSession);
    }

    /// <include file='IMFMediaKeys.xml' path='doc/member[@name="IMFMediaKeys.get_KeySystem"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_KeySystem([NativeTypeName("BSTR *")] ushort** keySystem)
    {
        return ((delegate* unmanaged<IMFMediaKeys*, ushort**, int>)(lpVtbl[4]))((IMFMediaKeys*)Unsafe.AsPointer(ref this), keySystem);
    }

    /// <include file='IMFMediaKeys.xml' path='doc/member[@name="IMFMediaKeys.Shutdown"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Shutdown()
    {
        return ((delegate* unmanaged<IMFMediaKeys*, int>)(lpVtbl[5]))((IMFMediaKeys*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFMediaKeys.xml' path='doc/member[@name="IMFMediaKeys.GetSuspendNotify"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetSuspendNotify(IMFCdmSuspendNotify** notify)
    {
        return ((delegate* unmanaged<IMFMediaKeys*, IMFCdmSuspendNotify**, int>)(lpVtbl[6]))((IMFMediaKeys*)Unsafe.AsPointer(ref this), notify);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateSession([NativeTypeName("BSTR")] ushort* mimeType, [NativeTypeName("const BYTE *")] byte* initData, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("const BYTE *")] byte* customData, [NativeTypeName("DWORD")] uint cbCustomData, IMFMediaKeySessionNotify* notify, IMFMediaKeySession** ppSession);

        [VtblIndex(4)]
        HRESULT get_KeySystem([NativeTypeName("BSTR *")] ushort** keySystem);

        [VtblIndex(5)]
        HRESULT Shutdown();

        [VtblIndex(6)]
        HRESULT GetSuspendNotify(IMFCdmSuspendNotify** notify);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (BSTR, const BYTE *, DWORD, const BYTE *, DWORD, IMFMediaKeySessionNotify *, IMFMediaKeySession **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, byte*, uint, byte*, uint, IMFMediaKeySessionNotify*, IMFMediaKeySession**, int> CreateSession;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_KeySystem;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Shutdown;

        [NativeTypeName("HRESULT (IMFCdmSuspendNotify **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFCdmSuspendNotify**, int> GetSuspendNotify;
    }
}
