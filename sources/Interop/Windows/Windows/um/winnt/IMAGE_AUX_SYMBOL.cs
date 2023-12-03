// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='IMAGE_AUX_SYMBOL.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct IMAGE_AUX_SYMBOL
{
    /// <include file='IMAGE_AUX_SYMBOL.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL.Sym"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L18945_C5")]
    public _Sym_e__Struct Sym;

    /// <include file='IMAGE_AUX_SYMBOL.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL.File"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L18965_C5")]
    public _File_e__Struct File;

    /// <include file='IMAGE_AUX_SYMBOL.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL.Section"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L18968_C5")]
    public _Section_e__Struct Section;

    /// <include file='IMAGE_AUX_SYMBOL.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL.TokenDef"]/*' />
    [FieldOffset(0)]
    public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;

    /// <include file='IMAGE_AUX_SYMBOL.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL.CRC"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L18979_C5")]
    public _CRC_e__Struct CRC;

    /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _Sym_e__Struct
    {
        /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.TagIndex"]/*' />
        [NativeTypeName("DWORD")]
        public uint TagIndex;

        /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.Misc"]/*' />
        [NativeTypeName("__AnonymousRecord_winnt_L18947_C9")]
        public _Misc_e__Union Misc;

        /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.FcnAry"]/*' />
        [NativeTypeName("__AnonymousRecord_winnt_L18954_C9")]
        public _FcnAry_e__Union FcnAry;

        /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.TvIndex"]/*' />
        [NativeTypeName("WORD")]
        public ushort TvIndex;

        /// <include file='_Misc_e__Union.xml' path='doc/member[@name="_Misc_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit, Pack = 2)]
        public partial struct _Misc_e__Union
        {
            /// <include file='_Misc_e__Union.xml' path='doc/member[@name="_Misc_e__Union.LnSz"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_winnt_L18948_C13")]
            public _LnSz_e__Struct LnSz;

            /// <include file='_Misc_e__Union.xml' path='doc/member[@name="_Misc_e__Union.TotalSize"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("DWORD")]
            public uint TotalSize;

            /// <include file='_LnSz_e__Struct.xml' path='doc/member[@name="_LnSz_e__Struct"]/*' />
            public partial struct _LnSz_e__Struct
            {
                /// <include file='_LnSz_e__Struct.xml' path='doc/member[@name="_LnSz_e__Struct.Linenumber"]/*' />
                [NativeTypeName("WORD")]
                public ushort Linenumber;

                /// <include file='_LnSz_e__Struct.xml' path='doc/member[@name="_LnSz_e__Struct.Size"]/*' />
                [NativeTypeName("WORD")]
                public ushort Size;
            }
        }

        /// <include file='_FcnAry_e__Union.xml' path='doc/member[@name="_FcnAry_e__Union"]/*' />
        [StructLayout(LayoutKind.Explicit)]
        public partial struct _FcnAry_e__Union
        {
            /// <include file='_FcnAry_e__Union.xml' path='doc/member[@name="_FcnAry_e__Union.Function"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_winnt_L18955_C13")]
            public _Function_e__Struct Function;

            /// <include file='_FcnAry_e__Union.xml' path='doc/member[@name="_FcnAry_e__Union.Array"]/*' />
            [FieldOffset(0)]
            [NativeTypeName("__AnonymousRecord_winnt_L18959_C13")]
            public _Array_e__Struct Array;

            /// <include file='_Function_e__Struct.xml' path='doc/member[@name="_Function_e__Struct"]/*' />
            [StructLayout(LayoutKind.Sequential, Pack = 2)]
            public partial struct _Function_e__Struct
            {
                /// <include file='_Function_e__Struct.xml' path='doc/member[@name="_Function_e__Struct.PointerToLinenumber"]/*' />
                [NativeTypeName("DWORD")]
                public uint PointerToLinenumber;

                /// <include file='_Function_e__Struct.xml' path='doc/member[@name="_Function_e__Struct.PointerToNextFunction"]/*' />
                [NativeTypeName("DWORD")]
                public uint PointerToNextFunction;
            }

            /// <include file='_Array_e__Struct.xml' path='doc/member[@name="_Array_e__Struct"]/*' />
            public partial struct _Array_e__Struct
            {
                /// <include file='_Array_e__Struct.xml' path='doc/member[@name="_Array_e__Struct.Dimension"]/*' />
                [NativeTypeName("WORD[4]")]
                public _Dimension_e__FixedBuffer Dimension;

                /// <include file='_Dimension_e__FixedBuffer.xml' path='doc/member[@name="_Dimension_e__FixedBuffer"]/*' />
                [InlineArray(4)]
                public partial struct _Dimension_e__FixedBuffer
                {
                    public ushort e0;
                }
            }
        }
    }

    /// <include file='_File_e__Struct.xml' path='doc/member[@name="_File_e__Struct"]/*' />
    public partial struct _File_e__Struct
    {
        /// <include file='_File_e__Struct.xml' path='doc/member[@name="_File_e__Struct.Name"]/*' />
        [NativeTypeName("BYTE[18]")]
        public _Name_e__FixedBuffer Name;

        /// <include file='_Name_e__FixedBuffer.xml' path='doc/member[@name="_Name_e__FixedBuffer"]/*' />
        [InlineArray(18)]
        public partial struct _Name_e__FixedBuffer
        {
            public byte e0;
        }
    }

    /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _Section_e__Struct
    {
        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.Length"]/*' />
        [NativeTypeName("DWORD")]
        public uint Length;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.NumberOfRelocations"]/*' />
        [NativeTypeName("WORD")]
        public ushort NumberOfRelocations;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.NumberOfLinenumbers"]/*' />
        [NativeTypeName("WORD")]
        public ushort NumberOfLinenumbers;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.CheckSum"]/*' />
        [NativeTypeName("DWORD")]
        public uint CheckSum;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.Number"]/*' />
        public short Number;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.Selection"]/*' />
        public byte Selection;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.bReserved"]/*' />
        public byte bReserved;

        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.HighNumber"]/*' />
        public short HighNumber;
    }

    /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public partial struct _CRC_e__Struct
    {
        /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct.crc"]/*' />
        [NativeTypeName("DWORD")]
        public uint crc;

        /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct.rgbReserved"]/*' />
        [NativeTypeName("BYTE[14]")]
        public _rgbReserved_e__FixedBuffer rgbReserved;

        /// <include file='_rgbReserved_e__FixedBuffer.xml' path='doc/member[@name="_rgbReserved_e__FixedBuffer"]/*' />
        [StructLayout(LayoutKind.Sequential, Pack = 2)]
        [InlineArray(14)]
        public partial struct _rgbReserved_e__FixedBuffer
        {
            public byte e0;
        }
    }
}
