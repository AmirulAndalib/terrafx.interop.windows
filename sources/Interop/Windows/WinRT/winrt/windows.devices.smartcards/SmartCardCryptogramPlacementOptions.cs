// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='SmartCardCryptogramPlacementOptions.xml' path='doc/member[@name="SmartCardCryptogramPlacementOptions"]/*' />
[NativeTypeName("unsigned int")]
public enum SmartCardCryptogramPlacementOptions : uint
{
    /// <include file='SmartCardCryptogramPlacementOptions.xml' path='doc/member[@name="SmartCardCryptogramPlacementOptions.SmartCardCryptogramPlacementOptions_None"]/*' />
    SmartCardCryptogramPlacementOptions_None = 0,

    /// <include file='SmartCardCryptogramPlacementOptions.xml' path='doc/member[@name="SmartCardCryptogramPlacementOptions.SmartCardCryptogramPlacementOptions_UnitsAreInNibbles"]/*' />
    SmartCardCryptogramPlacementOptions_UnitsAreInNibbles = 0x1,

    /// <include file='SmartCardCryptogramPlacementOptions.xml' path='doc/member[@name="SmartCardCryptogramPlacementOptions.SmartCardCryptogramPlacementOptions_ChainOutput"]/*' />
    SmartCardCryptogramPlacementOptions_ChainOutput = 0x2,
}
