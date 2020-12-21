// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    [NativeTypeName("uint32_t")]
    public enum MLOperatorAttributeType : uint
    {
        Undefined = 0,
        Float = 2,
        Int = 3,
        String = 4,
        FloatArray = 7,
        IntArray = 8,
        StringArray = 9,
    }
}
