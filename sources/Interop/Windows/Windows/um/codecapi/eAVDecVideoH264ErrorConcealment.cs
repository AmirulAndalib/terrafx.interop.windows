// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows
{
    public enum eAVDecVideoH264ErrorConcealment
    {
        eErrorConcealmentTypeDrop = 0,
        eErrorConcealmentTypeBasic = 1,
        eErrorConcealmentTypeAdvanced = 2,
        eErrorConcealmentTypeDXVASetBlack = 3,
    }
}