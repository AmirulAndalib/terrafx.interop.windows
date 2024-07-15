// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mssip.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER"]/*' />
public unsafe partial struct SIP_ADD_NEWPROVIDER
{
    /// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER.pgSubject"]/*' />
    public Guid* pgSubject;

    /// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER.pwszDLLFileName"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pwszDLLFileName;

    /// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER.pwszMagicNumber"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pwszMagicNumber;

    /// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER.pwszIsFunctionName"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pwszIsFunctionName;

    /// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER.pwszGetFuncName"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pwszGetFuncName;

    /// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER.pwszPutFuncName"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pwszPutFuncName;

    /// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER.pwszCreateFuncName"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pwszCreateFuncName;

    /// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER.pwszVerifyFuncName"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pwszVerifyFuncName;

    /// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER.pwszRemoveFuncName"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pwszRemoveFuncName;

    /// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER.pwszIsFunctionNameFmt2"]/*' />
    [NativeTypeName("WCHAR *")]
    public char* pwszIsFunctionNameFmt2;

    /// <include file='SIP_ADD_NEWPROVIDER.xml' path='doc/member[@name="SIP_ADD_NEWPROVIDER.pwszGetCapFuncName"]/*' />
    [NativeTypeName("PWSTR")]
    public char* pwszGetCapFuncName;
}
