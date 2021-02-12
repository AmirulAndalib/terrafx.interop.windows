// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("#define FADF_AUTO ( 0x1 )")]
        public const int FADF_AUTO = (0x1);

        [NativeTypeName("#define FADF_STATIC ( 0x2 )")]
        public const int FADF_STATIC = (0x2);

        [NativeTypeName("#define FADF_EMBEDDED ( 0x4 )")]
        public const int FADF_EMBEDDED = (0x4);

        [NativeTypeName("#define FADF_FIXEDSIZE ( 0x10 )")]
        public const int FADF_FIXEDSIZE = (0x10);

        [NativeTypeName("#define FADF_RECORD ( 0x20 )")]
        public const int FADF_RECORD = (0x20);

        [NativeTypeName("#define FADF_HAVEIID ( 0x40 )")]
        public const int FADF_HAVEIID = (0x40);

        [NativeTypeName("#define FADF_HAVEVARTYPE ( 0x80 )")]
        public const int FADF_HAVEVARTYPE = (0x80);

        [NativeTypeName("#define FADF_BSTR ( 0x100 )")]
        public const int FADF_BSTR = (0x100);

        [NativeTypeName("#define FADF_UNKNOWN ( 0x200 )")]
        public const int FADF_UNKNOWN = (0x200);

        [NativeTypeName("#define FADF_DISPATCH ( 0x400 )")]
        public const int FADF_DISPATCH = (0x400);

        [NativeTypeName("#define FADF_VARIANT ( 0x800 )")]
        public const int FADF_VARIANT = (0x800);

        [NativeTypeName("#define FADF_RESERVED ( 0xf008 )")]
        public const int FADF_RESERVED = (0xf008);

        [NativeTypeName("#define PARAMFLAG_NONE ( 0 )")]
        public const int PARAMFLAG_NONE = (0);

        [NativeTypeName("#define PARAMFLAG_FIN ( 0x1 )")]
        public const int PARAMFLAG_FIN = (0x1);

        [NativeTypeName("#define PARAMFLAG_FOUT ( 0x2 )")]
        public const int PARAMFLAG_FOUT = (0x2);

        [NativeTypeName("#define PARAMFLAG_FLCID ( 0x4 )")]
        public const int PARAMFLAG_FLCID = (0x4);

        [NativeTypeName("#define PARAMFLAG_FRETVAL ( 0x8 )")]
        public const int PARAMFLAG_FRETVAL = (0x8);

        [NativeTypeName("#define PARAMFLAG_FOPT ( 0x10 )")]
        public const int PARAMFLAG_FOPT = (0x10);

        [NativeTypeName("#define PARAMFLAG_FHASDEFAULT ( 0x20 )")]
        public const int PARAMFLAG_FHASDEFAULT = (0x20);

        [NativeTypeName("#define PARAMFLAG_FHASCUSTDATA ( 0x40 )")]
        public const int PARAMFLAG_FHASCUSTDATA = (0x40);

        [NativeTypeName("#define IDLFLAG_NONE ( PARAMFLAG_NONE )")]
        public const int IDLFLAG_NONE = ((0));

        [NativeTypeName("#define IDLFLAG_FIN ( PARAMFLAG_FIN )")]
        public const int IDLFLAG_FIN = ((0x1));

        [NativeTypeName("#define IDLFLAG_FOUT ( PARAMFLAG_FOUT )")]
        public const int IDLFLAG_FOUT = ((0x2));

        [NativeTypeName("#define IDLFLAG_FLCID ( PARAMFLAG_FLCID )")]
        public const int IDLFLAG_FLCID = ((0x4));

        [NativeTypeName("#define IDLFLAG_FRETVAL ( PARAMFLAG_FRETVAL )")]
        public const int IDLFLAG_FRETVAL = ((0x8));

        [NativeTypeName("#define IMPLTYPEFLAG_FDEFAULT ( 0x1 )")]
        public const int IMPLTYPEFLAG_FDEFAULT = (0x1);

        [NativeTypeName("#define IMPLTYPEFLAG_FSOURCE ( 0x2 )")]
        public const int IMPLTYPEFLAG_FSOURCE = (0x2);

        [NativeTypeName("#define IMPLTYPEFLAG_FRESTRICTED ( 0x4 )")]
        public const int IMPLTYPEFLAG_FRESTRICTED = (0x4);

        [NativeTypeName("#define IMPLTYPEFLAG_FDEFAULTVTABLE ( 0x8 )")]
        public const int IMPLTYPEFLAG_FDEFAULTVTABLE = (0x8);

        [NativeTypeName("#define DISPID_UNKNOWN ( -1 )")]
        public const int DISPID_UNKNOWN = (-1);

        [NativeTypeName("#define DISPID_VALUE ( 0 )")]
        public const int DISPID_VALUE = (0);

        [NativeTypeName("#define DISPID_PROPERTYPUT ( -3 )")]
        public const int DISPID_PROPERTYPUT = (-3);

        [NativeTypeName("#define DISPID_NEWENUM ( -4 )")]
        public const int DISPID_NEWENUM = (-4);

        [NativeTypeName("#define DISPID_EVALUATE ( -5 )")]
        public const int DISPID_EVALUATE = (-5);

        [NativeTypeName("#define DISPID_CONSTRUCTOR ( -6 )")]
        public const int DISPID_CONSTRUCTOR = (-6);

        [NativeTypeName("#define DISPID_DESTRUCTOR ( -7 )")]
        public const int DISPID_DESTRUCTOR = (-7);

        [NativeTypeName("#define DISPID_COLLECT ( -8 )")]
        public const int DISPID_COLLECT = (-8);

        public static readonly Guid IID_ICreateTypeInfo = new Guid(0x00020405, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ICreateTypeInfo2 = new Guid(0x0002040E, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ICreateTypeLib = new Guid(0x00020406, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ICreateTypeLib2 = new Guid(0x0002040F, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IDispatch = new Guid(0x00020400, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IEnumVARIANT = new Guid(0x00020404, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ITypeComp = new Guid(0x00020403, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ITypeInfo = new Guid(0x00020401, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ITypeInfo2 = new Guid(0x00020412, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ITypeLib = new Guid(0x00020402, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ITypeLib2 = new Guid(0x00020411, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ITypeChangeEvents = new Guid(0x00020410, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IErrorInfo = new Guid(0x1CF2B120, 0x547D, 0x101B, 0x8E, 0x65, 0x08, 0x00, 0x2B, 0x2B, 0xD1, 0x19);

        public static readonly Guid IID_ICreateErrorInfo = new Guid(0x22F03340, 0x547D, 0x101B, 0x8E, 0x65, 0x08, 0x00, 0x2B, 0x2B, 0xD1, 0x19);

        public static readonly Guid IID_ISupportErrorInfo = new Guid(0xDF0B3D60, 0x548F, 0x101B, 0x8E, 0x65, 0x08, 0x00, 0x2B, 0x2B, 0xD1, 0x19);

        public static readonly Guid IID_ITypeFactory = new Guid(0x0000002E, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_ITypeMarshal = new Guid(0x0000002D, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IRecordInfo = new Guid(0x0000002F, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        public static readonly Guid IID_IErrorLog = new Guid(0x3127CA40, 0x446E, 0x11CE, 0x81, 0x35, 0x00, 0xAA, 0x00, 0x4B, 0xB8, 0x51);

        public static readonly Guid IID_IPropertyBag = new Guid(0x55272A00, 0x42CB, 0x11CE, 0x81, 0x35, 0x00, 0xAA, 0x00, 0x4B, 0xB8, 0x51);

        public static readonly Guid IID_ITypeLibRegistrationReader = new Guid(0xED6A8A2A, 0xB160, 0x4E77, 0x8F, 0x73, 0xAA, 0x74, 0x35, 0xCD, 0x5C, 0x27);

        public static readonly Guid IID_ITypeLibRegistration = new Guid(0x76A3E735, 0x02DF, 0x4A12, 0x98, 0xEB, 0x04, 0x3A, 0xD3, 0x60, 0x0A, 0xF3);
    }
}
