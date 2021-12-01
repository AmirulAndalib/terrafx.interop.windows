// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.SpeechStreamFileMode;

namespace TerraFX.Interop.Windows;

/// <include file='ISpeechFileStream.xml' path='doc/member[@name="ISpeechFileStream"]/*' />
[Guid("AF67F125-AB39-4E93-B4A2-CC2E66E182A7")]
[NativeTypeName("struct ISpeechFileStream : ISpeechBaseStream")]
[NativeInheritance("ISpeechBaseStream")]
public unsafe partial struct ISpeechFileStream : ISpeechFileStream.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechFileStream*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechFileStream*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpeechFileStream*, uint>)(lpVtbl[1]))((ISpeechFileStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechFileStream*, uint>)(lpVtbl[2]))((ISpeechFileStream*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechFileStream*, uint*, int>)(lpVtbl[3]))((ISpeechFileStream*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<ISpeechFileStream*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((ISpeechFileStream*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<ISpeechFileStream*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((ISpeechFileStream*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<ISpeechFileStream*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((ISpeechFileStream*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref="ISpeechBaseStream.get_Format" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Format(ISpeechAudioFormat** AudioFormat)
    {
        return ((delegate* unmanaged<ISpeechFileStream*, ISpeechAudioFormat**, int>)(lpVtbl[7]))((ISpeechFileStream*)Unsafe.AsPointer(ref this), AudioFormat);
    }

    /// <inheritdoc cref="ISpeechBaseStream.putref_Format" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT putref_Format(ISpeechAudioFormat* AudioFormat)
    {
        return ((delegate* unmanaged<ISpeechFileStream*, ISpeechAudioFormat*, int>)(lpVtbl[8]))((ISpeechFileStream*)Unsafe.AsPointer(ref this), AudioFormat);
    }

    /// <inheritdoc cref="ISpeechBaseStream.Read" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Read(VARIANT* Buffer, [NativeTypeName("long")] int NumberOfBytes, [NativeTypeName("long *")] int* BytesRead)
    {
        return ((delegate* unmanaged<ISpeechFileStream*, VARIANT*, int, int*, int>)(lpVtbl[9]))((ISpeechFileStream*)Unsafe.AsPointer(ref this), Buffer, NumberOfBytes, BytesRead);
    }

    /// <inheritdoc cref="ISpeechBaseStream.Write" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Write(VARIANT Buffer, [NativeTypeName("long *")] int* BytesWritten)
    {
        return ((delegate* unmanaged<ISpeechFileStream*, VARIANT, int*, int>)(lpVtbl[10]))((ISpeechFileStream*)Unsafe.AsPointer(ref this), Buffer, BytesWritten);
    }

    /// <inheritdoc cref="ISpeechBaseStream.Seek" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Seek(VARIANT Position, SpeechStreamSeekPositionType Origin, VARIANT* NewPosition)
    {
        return ((delegate* unmanaged<ISpeechFileStream*, VARIANT, SpeechStreamSeekPositionType, VARIANT*, int>)(lpVtbl[11]))((ISpeechFileStream*)Unsafe.AsPointer(ref this), Position, Origin, NewPosition);
    }

    /// <include file='ISpeechFileStream.xml' path='doc/member[@name="ISpeechFileStream.Open"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Open([NativeTypeName("BSTR")] ushort* FileName, SpeechStreamFileMode FileMode = SSFMOpenForRead, [NativeTypeName("VARIANT_BOOL")] short DoEvents = 0)
    {
        return ((delegate* unmanaged<ISpeechFileStream*, ushort*, SpeechStreamFileMode, short, int>)(lpVtbl[12]))((ISpeechFileStream*)Unsafe.AsPointer(ref this), FileName, FileMode, DoEvents);
    }

    /// <include file='ISpeechFileStream.xml' path='doc/member[@name="ISpeechFileStream.Close"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<ISpeechFileStream*, int>)(lpVtbl[13]))((ISpeechFileStream*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ISpeechBaseStream.Interface
    {
        [VtblIndex(12)]
        HRESULT Open([NativeTypeName("BSTR")] ushort* FileName, SpeechStreamFileMode FileMode = SSFMOpenForRead, [NativeTypeName("VARIANT_BOOL")] short DoEvents = 0);

        [VtblIndex(13)]
        HRESULT Close();
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (ISpeechAudioFormat **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechAudioFormat**, int> get_Format;

        [NativeTypeName("HRESULT (ISpeechAudioFormat *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechAudioFormat*, int> putref_Format;

        [NativeTypeName("HRESULT (VARIANT *, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int, int*, int> Read;

        [NativeTypeName("HRESULT (VARIANT, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int*, int> Write;

        [NativeTypeName("HRESULT (VARIANT, SpeechStreamSeekPositionType, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, SpeechStreamSeekPositionType, VARIANT*, int> Seek;

        [NativeTypeName("HRESULT (BSTR, SpeechStreamFileMode, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, SpeechStreamFileMode, short, int> Open;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }
}
