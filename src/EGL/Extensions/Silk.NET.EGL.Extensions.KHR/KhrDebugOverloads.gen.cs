// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.KHR
{
    public static class KhrDebugOverloads
    {
        public static unsafe int DebugMessageControl(this KhrDebug thisApi, [Flow(FlowDirection.In)] PfnDebugProcKhr callback, [Flow(FlowDirection.In)] ReadOnlySpan<nint> attrib_list)
        {
            // SpanOverloader
            return thisApi.DebugMessageControl(callback, in attrib_list.GetPinnableReference());
        }

        public static unsafe bool QueryDebug(this KhrDebug thisApi, [Flow(FlowDirection.In)] int attribute, [Flow(FlowDirection.Out)] Span<nint> value)
        {
            // SpanOverloader
            return thisApi.QueryDebug(attribute, out value.GetPinnableReference());
        }

    }
}
