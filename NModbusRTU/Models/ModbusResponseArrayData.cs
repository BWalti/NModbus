﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ModbusResponseArrayData.cs" company="DTV-Online">
//   Copyright(c) 2018 Dr. Peter Trimmel. All rights reserved.
// </copyright>
// <license>
// Licensed under the MIT license. See the LICENSE file in the project root for more information.
// </license>
// --------------------------------------------------------------------------------------------------------------------
namespace NModbusRTU.Models
{
    /// <summary>
    /// Helper class to hold all Modbus response data.
    /// </summary>
    public class ModbusResponseArrayData<T> where T : new()
    {
        /// <summary>
        /// The Modbus request data.
        /// </summary>
        public ModbusRequestData Request { get; } = new ModbusRequestData();

        /// <summary>
        /// The Modbus data values.
        /// </summary>
        public T[] Values { get; } = new T[] { };

        /// <summary>
        /// Initializes a new instance of the <see cref="ModbusResponseArrayData&lt;T&gt;"/> class.
        /// </summary>
        public ModbusResponseArrayData() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModbusResponseArrayData&lt;T&gt;"/> class.
        /// </summary>
        /// <param name="request">The Modbus request data.</param>
        /// <param name="values">The array of data values.</param>
        public ModbusResponseArrayData(ModbusRequestData request, T[] values)
        {
            this.Request = request;
            this.Values = values;
        }
    }
}
