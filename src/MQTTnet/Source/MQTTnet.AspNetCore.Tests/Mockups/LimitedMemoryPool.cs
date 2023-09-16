// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Buffers;

namespace MQTTnet.AspNetCore.Tests.Mockups
{
    public class LimitedMemoryPool : MemoryPool<byte>
    {
        protected override void Dispose(bool disposing)
        {
        }

        public override IMemoryOwner<byte> Rent(int minBufferSize = -1)
        {
            return new MemoryOwner(minBufferSize);
        }

        public override int MaxBufferSize { get; }
    }
}