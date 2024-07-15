// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IWICStream.xml' path='doc/member[@name="IWICStream"]/*' />
[Guid("135FF860-22B7-4DDF-B0F6-218F4F299A43")]
[NativeTypeName("struct IWICStream : IStream")]
[NativeInheritance("IStream")]
public unsafe partial struct IWICStream : IWICStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICStream));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, Guid*, void**, int>)(lpVtbl[0]))((IWICStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, uint>)(lpVtbl[1]))((IWICStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, uint>)(lpVtbl[2]))((IWICStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ISequentialStream.Read" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, void*, uint, uint*, int>)(lpVtbl[3]))((IWICStream*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
    }

    /// <inheritdoc cref="ISequentialStream.Write" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write([NativeTypeName("const void *")] void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbWritten)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, void*, uint, uint*, int>)(lpVtbl[4]))((IWICStream*)Unsafe.AsPointer(ref this), pv, cb, pcbWritten);
    }

    /// <inheritdoc cref="IStream.Seek" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int>)(lpVtbl[5]))((IWICStream*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
    }

    /// <inheritdoc cref="IStream.SetSize" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSize(ULARGE_INTEGER libNewSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, ULARGE_INTEGER, int>)(lpVtbl[6]))((IWICStream*)Unsafe.AsPointer(ref this), libNewSize);
    }

    /// <inheritdoc cref="IStream.CopyTo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyTo(IStream* pstm, ULARGE_INTEGER cb, ULARGE_INTEGER* pcbRead, ULARGE_INTEGER* pcbWritten)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int>)(lpVtbl[7]))((IWICStream*)Unsafe.AsPointer(ref this), pstm, cb, pcbRead, pcbWritten);
    }

    /// <inheritdoc cref="IStream.Commit" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, uint, int>)(lpVtbl[8]))((IWICStream*)Unsafe.AsPointer(ref this), grfCommitFlags);
    }

    /// <inheritdoc cref="IStream.Revert" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, int>)(lpVtbl[9]))((IWICStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IStream.LockRegion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[10]))((IWICStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref="IStream.UnlockRegion" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UnlockRegion(ULARGE_INTEGER libOffset, ULARGE_INTEGER cb, [NativeTypeName("DWORD")] uint dwLockType)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int>)(lpVtbl[11]))((IWICStream*)Unsafe.AsPointer(ref this), libOffset, cb, dwLockType);
    }

    /// <inheritdoc cref="IStream.Stat" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, STATSTG*, uint, int>)(lpVtbl[12]))((IWICStream*)Unsafe.AsPointer(ref this), pstatstg, grfStatFlag);
    }

    /// <inheritdoc cref="IStream.Clone" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Clone(IStream** ppstm)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, IStream**, int>)(lpVtbl[13]))((IWICStream*)Unsafe.AsPointer(ref this), ppstm);
    }

    /// <include file='IWICStream.xml' path='doc/member[@name="IWICStream.InitializeFromIStream"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT InitializeFromIStream(IStream* pIStream)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, IStream*, int>)(lpVtbl[14]))((IWICStream*)Unsafe.AsPointer(ref this), pIStream);
    }

    /// <include file='IWICStream.xml' path='doc/member[@name="IWICStream.InitializeFromFilename"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT InitializeFromFilename([NativeTypeName("LPCWSTR")] char* wzFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, char*, uint, int>)(lpVtbl[15]))((IWICStream*)Unsafe.AsPointer(ref this), wzFileName, dwDesiredAccess);
    }

    /// <include file='IWICStream.xml' path='doc/member[@name="IWICStream.InitializeFromMemory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT InitializeFromMemory([NativeTypeName("WICInProcPointer")] byte* pbBuffer, [NativeTypeName("DWORD")] uint cbBufferSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, byte*, uint, int>)(lpVtbl[16]))((IWICStream*)Unsafe.AsPointer(ref this), pbBuffer, cbBufferSize);
    }

    /// <include file='IWICStream.xml' path='doc/member[@name="IWICStream.InitializeFromIStreamRegion"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT InitializeFromIStreamRegion(IStream* pIStream, ULARGE_INTEGER ulOffset, ULARGE_INTEGER ulMaxSize)
    {
        return ((delegate* unmanaged[MemberFunction]<IWICStream*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER, int>)(lpVtbl[17]))((IWICStream*)Unsafe.AsPointer(ref this), pIStream, ulOffset, ulMaxSize);
    }

    public interface Interface : IStream.Interface
    {
        [VtblIndex(14)]
        HRESULT InitializeFromIStream(IStream* pIStream);

        [VtblIndex(15)]
        HRESULT InitializeFromFilename([NativeTypeName("LPCWSTR")] char* wzFileName, [NativeTypeName("DWORD")] uint dwDesiredAccess);

        [VtblIndex(16)]
        HRESULT InitializeFromMemory([NativeTypeName("WICInProcPointer")] byte* pbBuffer, [NativeTypeName("DWORD")] uint cbBufferSize);

        [VtblIndex(17)]
        HRESULT InitializeFromIStreamRegion(IStream* pIStream, ULARGE_INTEGER ulOffset, ULARGE_INTEGER ulMaxSize);
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

        [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint*, int> Read;

        [NativeTypeName("HRESULT (const void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, void*, uint, uint*, int> Write;

        [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> Seek;

        [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ULARGE_INTEGER, int> SetSize;

        [NativeTypeName("HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER *, ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER*, ULARGE_INTEGER*, int> CopyTo;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> Commit;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> Revert;

        [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> LockRegion;

        [NativeTypeName("HRESULT (ULARGE_INTEGER, ULARGE_INTEGER, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ULARGE_INTEGER, ULARGE_INTEGER, uint, int> UnlockRegion;

        [NativeTypeName("HRESULT (STATSTG *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, STATSTG*, uint, int> Stat;

        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream**, int> Clone;

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, int> InitializeFromIStream;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> InitializeFromFilename;

        [NativeTypeName("HRESULT (WICInProcPointer, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, uint, int> InitializeFromMemory;

        [NativeTypeName("HRESULT (IStream *, ULARGE_INTEGER, ULARGE_INTEGER) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IStream*, ULARGE_INTEGER, ULARGE_INTEGER, int> InitializeFromIStreamRegion;
    }
}
