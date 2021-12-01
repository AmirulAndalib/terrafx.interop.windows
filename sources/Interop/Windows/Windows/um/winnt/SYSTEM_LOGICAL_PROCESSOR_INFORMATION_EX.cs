// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX"]/*' />
public partial struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX
{
    /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Relationship"]/*' />
    public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;

    /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.xml' path='doc/member[@name="SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX.Anonymous"]/*' />
    [NativeTypeName("_SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:13645:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Processor"]/*' />
    public ref PROCESSOR_RELATIONSHIP Processor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Processor, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumaNode"]/*' />
    public ref NUMA_NODE_RELATIONSHIP NumaNode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.NumaNode, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Cache"]/*' />
    public ref CACHE_RELATIONSHIP Cache
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Cache, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Group"]/*' />
    public ref GROUP_RELATIONSHIP Group
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Group, 1));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Processor"]/*' />
        [FieldOffset(0)]
        public PROCESSOR_RELATIONSHIP Processor;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.NumaNode"]/*' />
        [FieldOffset(0)]
        public NUMA_NODE_RELATIONSHIP NumaNode;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Cache"]/*' />
        [FieldOffset(0)]
        public CACHE_RELATIONSHIP Cache;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Group"]/*' />
        [FieldOffset(0)]
        public GROUP_RELATIONSHIP Group;
    }
}
