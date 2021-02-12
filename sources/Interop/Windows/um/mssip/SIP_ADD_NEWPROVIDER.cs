// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SIP_ADD_NEWPROVIDER
    {
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        [NativeTypeName("GUID *")]
        public Guid* pgSubject;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszDLLFileName;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszMagicNumber;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszIsFunctionName;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszGetFuncName;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszPutFuncName;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszCreateFuncName;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszVerifyFuncName;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszRemoveFuncName;

        [NativeTypeName("WCHAR *")]
        public ushort* pwszIsFunctionNameFmt2;

        [NativeTypeName("PWSTR")]
        public ushort* pwszGetCapFuncName;
    }
}
