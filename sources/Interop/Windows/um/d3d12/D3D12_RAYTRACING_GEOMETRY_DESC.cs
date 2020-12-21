// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct D3D12_RAYTRACING_GEOMETRY_DESC
    {
        public D3D12_RAYTRACING_GEOMETRY_TYPE Type;

        public D3D12_RAYTRACING_GEOMETRY_FLAGS Flags;

        [NativeTypeName("D3D12_RAYTRACING_GEOMETRY_DESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/d3d12.h:12484:5)")]
        public _Anonymous_e__Union Anonymous;

        public ref D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.Triangles, 1));
            }
        }

        public ref D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.AABBs, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            public D3D12_RAYTRACING_GEOMETRY_TRIANGLES_DESC Triangles;

            [FieldOffset(0)]
            public D3D12_RAYTRACING_GEOMETRY_AABBS_DESC AABBs;
        }
    }
}
