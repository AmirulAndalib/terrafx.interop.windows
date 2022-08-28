// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TRANSACTION_OUTCOME.xml' path='doc/member[@name="TRANSACTION_OUTCOME"]/*' />
public enum TRANSACTION_OUTCOME
{
    /// <include file='TRANSACTION_OUTCOME.xml' path='doc/member[@name="TRANSACTION_OUTCOME.TransactionOutcomeUndetermined"]/*' />
    TransactionOutcomeUndetermined = 1,

    /// <include file='TRANSACTION_OUTCOME.xml' path='doc/member[@name="TRANSACTION_OUTCOME.TransactionOutcomeCommitted"]/*' />
    TransactionOutcomeCommitted,

    /// <include file='TRANSACTION_OUTCOME.xml' path='doc/member[@name="TRANSACTION_OUTCOME.TransactionOutcomeAborted"]/*' />
    TransactionOutcomeAborted,
}
