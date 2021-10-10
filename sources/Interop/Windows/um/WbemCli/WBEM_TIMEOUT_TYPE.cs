// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum WBEM_TIMEOUT_TYPE
    {
        WBEM_NO_WAIT = 0,
        WBEM_INFINITE = unchecked((int)(0xffffffff)),
    }
}
