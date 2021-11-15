// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public partial struct TOKEN_CONTROL
    {
        public LUID TokenId;

        public LUID AuthenticationId;

        public LUID ModifiedId;

        public TOKEN_SOURCE TokenSource;
    }
}