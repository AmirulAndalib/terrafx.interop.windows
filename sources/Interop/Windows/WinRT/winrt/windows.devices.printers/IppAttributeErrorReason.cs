// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='IppAttributeErrorReason.xml' path='doc/member[@name="IppAttributeErrorReason"]/*' />
public enum IppAttributeErrorReason
{
    /// <include file='IppAttributeErrorReason.xml' path='doc/member[@name="IppAttributeErrorReason.IppAttributeErrorReason_RequestEntityTooLarge"]/*' />
    IppAttributeErrorReason_RequestEntityTooLarge = 0,

    /// <include file='IppAttributeErrorReason.xml' path='doc/member[@name="IppAttributeErrorReason.IppAttributeErrorReason_AttributeNotSupported"]/*' />
    IppAttributeErrorReason_AttributeNotSupported = 1,

    /// <include file='IppAttributeErrorReason.xml' path='doc/member[@name="IppAttributeErrorReason.IppAttributeErrorReason_AttributeValuesNotSupported"]/*' />
    IppAttributeErrorReason_AttributeValuesNotSupported = 2,

    /// <include file='IppAttributeErrorReason.xml' path='doc/member[@name="IppAttributeErrorReason.IppAttributeErrorReason_AttributeNotSettable"]/*' />
    IppAttributeErrorReason_AttributeNotSettable = 3,

    /// <include file='IppAttributeErrorReason.xml' path='doc/member[@name="IppAttributeErrorReason.IppAttributeErrorReason_ConflictingAttributes"]/*' />
    IppAttributeErrorReason_ConflictingAttributes = 4,
}
