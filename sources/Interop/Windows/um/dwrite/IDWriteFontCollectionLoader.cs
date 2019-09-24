// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\dwrite.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>The font collection loader interface is used to construct a collection of fonts given a particular type of key. The font collection loader interface is recommended to be implemented by a singleton object. IMPORTANT: font collection loader implementations must not register themselves with a DirectWrite factory inside their constructors and must not unregister themselves in their destructors, because registration and unregistration operations increment and decrement the object reference count respectively. Instead, registration and unregistration of font file loaders with DirectWrite factory should be performed outside of the font file loader implementation as a separate step.</summary>
    [Guid("CCA920E4-52F0-492B-BFA8-29C72EE0A468")]
    public unsafe struct IDWriteFontCollectionLoader
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(IDWriteFontCollectionLoader* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(IDWriteFontCollectionLoader* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(IDWriteFontCollectionLoader* This);

        /// <summary>Creates a font file enumerator object that encapsulates a collection of font files. The font system calls back to this interface to create a font collection.</summary>
        /// <param name="factory">Factory associated with the loader.</param>
        /// <param name="collectionKey">Font collection key that uniquely identifies the collection of font files within the scope of the font collection loader being used.</param>
        /// <param name="collectionKeySize">Size of the font collection key in bytes.</param>
        /// <param name="fontFileEnumerator">Pointer to the newly created font file enumerator.</param>
        /// <returns>Standard HRESULT error code.</returns>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _CreateEnumeratorFromKey(IDWriteFontCollectionLoader* This, IDWriteFactory* factory, void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (IDWriteFontCollectionLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (IDWriteFontCollectionLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (IDWriteFontCollectionLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("HRESULT")]
        public int CreateEnumeratorFromKey(IDWriteFactory* factory, void* collectionKey, [NativeTypeName("UINT32")] uint collectionKeySize, IDWriteFontFileEnumerator** fontFileEnumerator)
        {
            fixed (IDWriteFontCollectionLoader* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_CreateEnumeratorFromKey>(lpVtbl->CreateEnumeratorFromKey)(This, factory, collectionKey, collectionKeySize, fontFileEnumerator);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr CreateEnumeratorFromKey;
        }
    }
}
