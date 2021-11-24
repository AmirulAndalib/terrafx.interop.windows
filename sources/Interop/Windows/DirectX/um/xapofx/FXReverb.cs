// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xapofx.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;

[Guid("7D9ACA56-CB68-4807-B632-B137352E8596")]
public partial struct FXReverb
{
    [NativeTypeName("#define FXREVERB_MIN_DIFFUSION 0.0f")]
    public const float FXREVERB_MIN_DIFFUSION = 0.0f;

    [NativeTypeName("#define FXREVERB_MAX_DIFFUSION 1.0f")]
    public const float FXREVERB_MAX_DIFFUSION = 1.0f;

    [NativeTypeName("#define FXREVERB_DEFAULT_DIFFUSION 0.9f")]
    public const float FXREVERB_DEFAULT_DIFFUSION = 0.9f;

    [NativeTypeName("#define FXREVERB_MIN_ROOMSIZE 0.0001f")]
    public const float FXREVERB_MIN_ROOMSIZE = 0.0001f;

    [NativeTypeName("#define FXREVERB_MAX_ROOMSIZE 1.0f")]
    public const float FXREVERB_MAX_ROOMSIZE = 1.0f;

    [NativeTypeName("#define FXREVERB_DEFAULT_ROOMSIZE 0.6f")]
    public const float FXREVERB_DEFAULT_ROOMSIZE = 0.6f;
}
