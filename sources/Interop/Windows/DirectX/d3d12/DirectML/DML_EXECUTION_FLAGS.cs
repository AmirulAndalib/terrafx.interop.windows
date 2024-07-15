// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='DML_EXECUTION_FLAGS.xml' path='doc/member[@name="DML_EXECUTION_FLAGS"]/*' />
[Flags]
public enum DML_EXECUTION_FLAGS
{
    /// <include file='DML_EXECUTION_FLAGS.xml' path='doc/member[@name="DML_EXECUTION_FLAGS.DML_EXECUTION_FLAG_NONE"]/*' />
    DML_EXECUTION_FLAG_NONE = 0,

    /// <include file='DML_EXECUTION_FLAGS.xml' path='doc/member[@name="DML_EXECUTION_FLAGS.DML_EXECUTION_FLAG_ALLOW_HALF_PRECISION_COMPUTATION"]/*' />
    DML_EXECUTION_FLAG_ALLOW_HALF_PRECISION_COMPUTATION = 0x1,

    /// <include file='DML_EXECUTION_FLAGS.xml' path='doc/member[@name="DML_EXECUTION_FLAGS.DML_EXECUTION_FLAG_DISABLE_META_COMMANDS"]/*' />
    DML_EXECUTION_FLAG_DISABLE_META_COMMANDS = 0x2,

    /// <include file='DML_EXECUTION_FLAGS.xml' path='doc/member[@name="DML_EXECUTION_FLAGS.DML_EXECUTION_FLAG_DESCRIPTORS_VOLATILE"]/*' />
    DML_EXECUTION_FLAG_DESCRIPTORS_VOLATILE = 0x4,
}
