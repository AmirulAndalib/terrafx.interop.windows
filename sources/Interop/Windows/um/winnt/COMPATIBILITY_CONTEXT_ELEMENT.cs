// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct COMPATIBILITY_CONTEXT_ELEMENT
    {
        [NativeTypeName("GUID")]
        public Guid Id;

        public ACTCTX_COMPATIBILITY_ELEMENT_TYPE Type;

        [NativeTypeName("ULONGLONG")]
        public ulong MaxVersionTested;
    }
}
