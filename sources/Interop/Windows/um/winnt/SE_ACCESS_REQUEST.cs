// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct SE_ACCESS_REQUEST
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("PSE_SECURITY_DESCRIPTOR")]
        public SE_SECURITY_DESCRIPTOR* SeSecurityDescriptor;

        [NativeTypeName("ACCESS_MASK")]
        public uint DesiredAccess;

        [NativeTypeName("ACCESS_MASK")]
        public uint PreviouslyGrantedAccess;

        [NativeTypeName("PSID")]
        public void* PrincipalSelfSid;

        [NativeTypeName("PGENERIC_MAPPING")]
        public GENERIC_MAPPING* GenericMapping;

        [NativeTypeName("DWORD")]
        public uint ObjectTypeListCount;

        [NativeTypeName("POBJECT_TYPE_LIST")]
        public OBJECT_TYPE_LIST* ObjectTypeList;
    }
}
