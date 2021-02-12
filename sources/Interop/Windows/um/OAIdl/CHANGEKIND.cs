// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum CHANGEKIND
    {
        CHANGEKIND_ADDMEMBER = 0,
        CHANGEKIND_DELETEMEMBER = (CHANGEKIND_ADDMEMBER + 1),
        CHANGEKIND_SETNAMES = (CHANGEKIND_DELETEMEMBER + 1),
        CHANGEKIND_SETDOCUMENTATION = (CHANGEKIND_SETNAMES + 1),
        CHANGEKIND_GENERAL = (CHANGEKIND_SETDOCUMENTATION + 1),
        CHANGEKIND_INVALIDATE = (CHANGEKIND_GENERAL + 1),
        CHANGEKIND_CHANGEFAILED = (CHANGEKIND_INVALIDATE + 1),
        CHANGEKIND_MAX = (CHANGEKIND_CHANGEFAILED + 1),
    }
}
