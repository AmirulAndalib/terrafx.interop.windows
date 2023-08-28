// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFStreamingSinkConfig.xml' path='doc/member[@name="IMFStreamingSinkConfig"]/*' />
[Guid("9DB7AA41-3CC5-40D4-8509-555804AD34CC")]
[NativeTypeName("struct IMFStreamingSinkConfig : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFStreamingSinkConfig : IMFStreamingSinkConfig.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFStreamingSinkConfig));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFStreamingSinkConfig*, Guid*, void**, int>)(lpVtbl[0]))((IMFStreamingSinkConfig*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFStreamingSinkConfig*, uint>)(lpVtbl[1]))((IMFStreamingSinkConfig*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFStreamingSinkConfig*, uint>)(lpVtbl[2]))((IMFStreamingSinkConfig*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFStreamingSinkConfig.xml' path='doc/member[@name="IMFStreamingSinkConfig.StartStreaming"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT StartStreaming(BOOL fSeekOffsetIsByteOffset, [NativeTypeName("QWORD")] ulong qwSeekOffset)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFStreamingSinkConfig*, BOOL, ulong, int>)(lpVtbl[3]))((IMFStreamingSinkConfig*)Unsafe.AsPointer(ref this), fSeekOffsetIsByteOffset, qwSeekOffset);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT StartStreaming(BOOL fSeekOffsetIsByteOffset, [NativeTypeName("QWORD")] ulong qwSeekOffset);
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

        [NativeTypeName("HRESULT (BOOL, QWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, ulong, int> StartStreaming;
    }
}
