// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct wireVARIANT
    {
        [NativeTypeName("DWORD")]
        public uint clSize;

        [NativeTypeName("DWORD")]
        public uint rpcReserved;

        [NativeTypeName("USHORT")]
        public ushort vt;

        [NativeTypeName("USHORT")]
        public ushort wReserved1;

        [NativeTypeName("USHORT")]
        public ushort wReserved2;

        [NativeTypeName("USHORT")]
        public ushort wReserved3;

        [NativeTypeName("_wireVARIANT::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:573:36)")]
        public _Anonymous_e__Union Anonymous;

        public ref long llVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.llVal, 1));
            }
        }

        public ref int lVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.lVal, 1));
            }
        }

        public ref byte bVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.bVal, 1));
            }
        }

        public ref short iVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.iVal, 1));
            }
        }

        public ref float fltVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.fltVal, 1));
            }
        }

        public ref double dblVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.dblVal, 1));
            }
        }

        public ref short boolVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.boolVal, 1));
            }
        }

        public ref int scode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.scode, 1));
            }
        }

        public ref CY cyVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cyVal, 1));
            }
        }

        public ref double date
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.date, 1));
            }
        }

        public ref FLAGGED_WORD_BLOB* bstrVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->bstrVal;
                }
            }
        }

        public ref IUnknown* punkVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->punkVal;
                }
            }
        }

        public ref IDispatch* pdispVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pdispVal;
                }
            }
        }

        public ref wireSAFEARRAY** parray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->parray;
                }
            }
        }

        public ref wireBRECORD* brecVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->brecVal;
                }
            }
        }

        public ref byte* pbVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pbVal;
                }
            }
        }

        public ref short* piVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->piVal;
                }
            }
        }

        public ref int* plVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->plVal;
                }
            }
        }

        public ref long* pllVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pllVal;
                }
            }
        }

        public ref float* pfltVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pfltVal;
                }
            }
        }

        public ref double* pdblVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pdblVal;
                }
            }
        }

        public ref short* pboolVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pboolVal;
                }
            }
        }

        public ref int* pscode
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pscode;
                }
            }
        }

        public ref CY* pcyVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pcyVal;
                }
            }
        }

        public ref double* pdate
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pdate;
                }
            }
        }

        public ref FLAGGED_WORD_BLOB** pbstrVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pbstrVal;
                }
            }
        }

        public ref IUnknown** ppunkVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->ppunkVal;
                }
            }
        }

        public ref IDispatch** ppdispVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->ppdispVal;
                }
            }
        }

        public ref wireSAFEARRAY*** pparray
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pparray;
                }
            }
        }

        public ref wireVARIANT** pvarVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pvarVal;
                }
            }
        }

        public ref sbyte cVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.cVal, 1));
            }
        }

        public ref ushort uiVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.uiVal, 1));
            }
        }

        public ref uint ulVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ulVal, 1));
            }
        }

        public ref ulong ullVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.ullVal, 1));
            }
        }

        public ref int intVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.intVal, 1));
            }
        }

        public ref uint uintVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.uintVal, 1));
            }
        }

        public ref DECIMAL decVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.decVal, 1));
            }
        }

        public ref DECIMAL* pdecVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pdecVal;
                }
            }
        }

        public ref sbyte* pcVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pcVal;
                }
            }
        }

        public ref ushort* puiVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->puiVal;
                }
            }
        }

        public ref uint* pulVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pulVal;
                }
            }
        }

        public ref ulong* pullVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pullVal;
                }
            }
        }

        public ref int* pintVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->pintVal;
                }
            }
        }

        public ref uint* puintVal
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->puintVal;
                }
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("LONGLONG")]
            public long llVal;

            [FieldOffset(0)]
            [NativeTypeName("LONG")]
            public int lVal;

            [FieldOffset(0)]
            [NativeTypeName("BYTE")]
            public byte bVal;

            [FieldOffset(0)]
            [NativeTypeName("SHORT")]
            public short iVal;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT")]
            public float fltVal;

            [FieldOffset(0)]
            [NativeTypeName("DOUBLE")]
            public double dblVal;

            [FieldOffset(0)]
            [NativeTypeName("VARIANT_BOOL")]
            public short boolVal;

            [FieldOffset(0)]
            [NativeTypeName("SCODE")]
            public int scode;

            [FieldOffset(0)]
            public CY cyVal;

            [FieldOffset(0)]
            [NativeTypeName("DATE")]
            public double date;

            [FieldOffset(0)]
            [NativeTypeName("wireBSTR")]
            public FLAGGED_WORD_BLOB* bstrVal;

            [FieldOffset(0)]
            [NativeTypeName("IUnknown *")]
            public IUnknown* punkVal;

            [FieldOffset(0)]
            [NativeTypeName("IDispatch *")]
            public IDispatch* pdispVal;

            [FieldOffset(0)]
            [NativeTypeName("wirePSAFEARRAY")]
            public wireSAFEARRAY** parray;

            [FieldOffset(0)]
            [NativeTypeName("wireBRECORD")]
            public wireBRECORD* brecVal;

            [FieldOffset(0)]
            [NativeTypeName("BYTE *")]
            public byte* pbVal;

            [FieldOffset(0)]
            [NativeTypeName("SHORT *")]
            public short* piVal;

            [FieldOffset(0)]
            [NativeTypeName("LONG *")]
            public int* plVal;

            [FieldOffset(0)]
            [NativeTypeName("LONGLONG *")]
            public long* pllVal;

            [FieldOffset(0)]
            [NativeTypeName("FLOAT *")]
            public float* pfltVal;

            [FieldOffset(0)]
            [NativeTypeName("DOUBLE *")]
            public double* pdblVal;

            [FieldOffset(0)]
            [NativeTypeName("VARIANT_BOOL *")]
            public short* pboolVal;

            [FieldOffset(0)]
            [NativeTypeName("SCODE *")]
            public int* pscode;

            [FieldOffset(0)]
            [NativeTypeName("CY *")]
            public CY* pcyVal;

            [FieldOffset(0)]
            [NativeTypeName("DATE *")]
            public double* pdate;

            [FieldOffset(0)]
            [NativeTypeName("wireBSTR *")]
            public FLAGGED_WORD_BLOB** pbstrVal;

            [FieldOffset(0)]
            [NativeTypeName("IUnknown **")]
            public IUnknown** ppunkVal;

            [FieldOffset(0)]
            [NativeTypeName("IDispatch **")]
            public IDispatch** ppdispVal;

            [FieldOffset(0)]
            [NativeTypeName("wirePSAFEARRAY *")]
            public wireSAFEARRAY*** pparray;

            [FieldOffset(0)]
            [NativeTypeName("wireVARIANT *")]
            public wireVARIANT** pvarVal;

            [FieldOffset(0)]
            [NativeTypeName("CHAR")]
            public sbyte cVal;

            [FieldOffset(0)]
            [NativeTypeName("USHORT")]
            public ushort uiVal;

            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint ulVal;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG")]
            public ulong ullVal;

            [FieldOffset(0)]
            [NativeTypeName("INT")]
            public int intVal;

            [FieldOffset(0)]
            [NativeTypeName("UINT")]
            public uint uintVal;

            [FieldOffset(0)]
            public DECIMAL decVal;

            [FieldOffset(0)]
            [NativeTypeName("DECIMAL *")]
            public DECIMAL* pdecVal;

            [FieldOffset(0)]
            [NativeTypeName("CHAR *")]
            public sbyte* pcVal;

            [FieldOffset(0)]
            [NativeTypeName("USHORT *")]
            public ushort* puiVal;

            [FieldOffset(0)]
            [NativeTypeName("ULONG *")]
            public uint* pulVal;

            [FieldOffset(0)]
            [NativeTypeName("ULONGLONG *")]
            public ulong* pullVal;

            [FieldOffset(0)]
            [NativeTypeName("INT *")]
            public int* pintVal;

            [FieldOffset(0)]
            [NativeTypeName("UINT *")]
            public uint* puintVal;
        }
    }
}
