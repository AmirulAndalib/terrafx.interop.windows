// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsiQuery.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MSITRANSFORM_VALIDATE
    {
        MSITRANSFORM_VALIDATE_LANGUAGE = 0x00000001,
        MSITRANSFORM_VALIDATE_PRODUCT = 0x00000002,
        MSITRANSFORM_VALIDATE_PLATFORM = 0x00000004,
        MSITRANSFORM_VALIDATE_MAJORVERSION = 0x00000008,
        MSITRANSFORM_VALIDATE_MINORVERSION = 0x00000010,
        MSITRANSFORM_VALIDATE_UPDATEVERSION = 0x00000020,
        MSITRANSFORM_VALIDATE_NEWLESSBASEVERSION = 0x00000040,
        MSITRANSFORM_VALIDATE_NEWLESSEQUALBASEVERSION = 0x00000080,
        MSITRANSFORM_VALIDATE_NEWEQUALBASEVERSION = 0x00000100,
        MSITRANSFORM_VALIDATE_NEWGREATEREQUALBASEVERSION = 0x00000200,
        MSITRANSFORM_VALIDATE_NEWGREATERBASEVERSION = 0x00000400,
        MSITRANSFORM_VALIDATE_UPGRADECODE = 0x00000800,
    }
}