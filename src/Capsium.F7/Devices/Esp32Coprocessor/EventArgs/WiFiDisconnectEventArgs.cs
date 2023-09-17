﻿using System;
using Capsium.Gateway.WiFi;
using Capsium.Devices.Esp32.MessagePayloads;
using Capsium.Gateways;
using Capsium.Gateways.Exceptions;
using System.Net;

namespace Capsium.Gateway.WiFi
{
    /// <summary>
    /// Data relating to a WiFi connection.
    /// </summary>
    public class WiFiDisconnectEventArgs : EventArgs
    {
        /// <summary>
        /// Status code of the connection request.
        /// </summary>
        public StatusCodes StatusCode { get; private set; }

        /// <summary>
        /// Date and time the event was generated.
        /// </summary>
        public DateTime When { get; private set; }

        /// <summary>
        /// Construct a WiFiConnectEventArgs request.
        /// </summary>
        /// <param name="statusCode">Status code of the network connection.</param>
        public WiFiDisconnectEventArgs(StatusCodes statusCode)
        {
            StatusCode = statusCode;
            When = DateTime.Now;
        }
    }
}
