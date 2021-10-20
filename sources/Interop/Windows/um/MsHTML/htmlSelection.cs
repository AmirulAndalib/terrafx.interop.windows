// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum htmlSelection
    {
        htmlSelectionNone = 0,
        htmlSelectionText = 1,
        htmlSelectionControl = 2,
        htmlSelectionTable = 3,
        htmlSelection_Max = 2147483647,
    }
}