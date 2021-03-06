﻿namespace Helios_PoC
{
    using System;

    public static class ByteArrayExtensions
    {
        public static byte[] Swap(this byte[] array)
        {
            if (array.Length != 2)
            {
                throw new Exception("Only byte arrays with length 2 are possible to being swapped.");
            }

            return new[] { array[1], array[0] };
        }
    }
}