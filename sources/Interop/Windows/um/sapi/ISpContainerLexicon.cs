// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8565572F-C094-41CC-B56E-10BD9C3FF044")]
    [NativeTypeName("struct ISpContainerLexicon : ISpLexicon")]
    [NativeInheritance("ISpLexicon")]
    public unsafe partial struct ISpContainerLexicon
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpContainerLexicon*, Guid*, void**, int>)(lpVtbl[0]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpContainerLexicon*, uint>)(lpVtbl[1]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpContainerLexicon*, uint>)(lpVtbl[2]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetPronunciations([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("DWORD")] uint dwFlags, SPWORDPRONUNCIATIONLIST* pWordPronunciationList)
        {
            return ((delegate* unmanaged<ISpContainerLexicon*, ushort*, ushort, uint, SPWORDPRONUNCIATIONLIST*, int>)(lpVtbl[3]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, dwFlags, pWordPronunciationList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT AddPronunciation([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, SPPARTOFSPEECH ePartOfSpeech, [NativeTypeName("PCSPPHONEID")] ushort* pszPronunciation)
        {
            return ((delegate* unmanaged<ISpContainerLexicon*, ushort*, ushort, SPPARTOFSPEECH, ushort*, int>)(lpVtbl[4]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, ePartOfSpeech, pszPronunciation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT RemovePronunciation([NativeTypeName("LPCWSTR")] ushort* pszWord, [NativeTypeName("WORD")] ushort LangID, SPPARTOFSPEECH ePartOfSpeech, [NativeTypeName("PCSPPHONEID")] ushort* pszPronunciation)
        {
            return ((delegate* unmanaged<ISpContainerLexicon*, ushort*, ushort, SPPARTOFSPEECH, ushort*, int>)(lpVtbl[5]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pszWord, LangID, ePartOfSpeech, pszPronunciation);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration)
        {
            return ((delegate* unmanaged<ISpContainerLexicon*, uint*, int>)(lpVtbl[6]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pdwGeneration);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetGenerationChange([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwGeneration, SPWORDLIST* pWordList)
        {
            return ((delegate* unmanaged<ISpContainerLexicon*, uint, uint*, SPWORDLIST*, int>)(lpVtbl[7]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), dwFlags, pdwGeneration, pWordList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT GetWords([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, SPWORDLIST* pWordList)
        {
            return ((delegate* unmanaged<ISpContainerLexicon*, uint, uint*, uint*, SPWORDLIST*, int>)(lpVtbl[8]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), dwFlags, pdwGeneration, pdwCookie, pWordList);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT AddLexicon(ISpLexicon* pAddLexicon, [NativeTypeName("DWORD")] uint dwFlags)
        {
            return ((delegate* unmanaged<ISpContainerLexicon*, ISpLexicon*, uint, int>)(lpVtbl[9]))((ISpContainerLexicon*)Unsafe.AsPointer(ref this), pAddLexicon, dwFlags);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpContainerLexicon*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpContainerLexicon*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ISpContainerLexicon*, uint> Release;

            [NativeTypeName("HRESULT (LPCWSTR, WORD, DWORD, SPWORDPRONUNCIATIONLIST *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpContainerLexicon*, ushort*, ushort, uint, SPWORDPRONUNCIATIONLIST*, int> GetPronunciations;

            [NativeTypeName("HRESULT (LPCWSTR, WORD, SPPARTOFSPEECH, PCSPPHONEID) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpContainerLexicon*, ushort*, ushort, SPPARTOFSPEECH, ushort*, int> AddPronunciation;

            [NativeTypeName("HRESULT (LPCWSTR, WORD, SPPARTOFSPEECH, PCSPPHONEID) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpContainerLexicon*, ushort*, ushort, SPPARTOFSPEECH, ushort*, int> RemovePronunciation;

            [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpContainerLexicon*, uint*, int> GetGeneration;

            [NativeTypeName("HRESULT (DWORD, DWORD *, SPWORDLIST *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpContainerLexicon*, uint, uint*, SPWORDLIST*, int> GetGenerationChange;

            [NativeTypeName("HRESULT (DWORD, DWORD *, DWORD *, SPWORDLIST *) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpContainerLexicon*, uint, uint*, uint*, SPWORDLIST*, int> GetWords;

            [NativeTypeName("HRESULT (ISpLexicon *, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<ISpContainerLexicon*, ISpLexicon*, uint, int> AddLexicon;
        }
    }
}
