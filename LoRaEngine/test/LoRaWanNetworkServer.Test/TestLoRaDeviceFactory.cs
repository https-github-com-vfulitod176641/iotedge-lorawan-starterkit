//
// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//
using LoRaWan.NetworkServer;

namespace LoRaWan.NetworkServer.Test
{
    internal class TestLoRaDeviceFactory : ILoRaDeviceFactory
    {
        private readonly ILoRaDeviceClient loRaDeviceClient;

        public TestLoRaDeviceFactory(ILoRaDeviceClient loRaDeviceClient)
        {
            this.loRaDeviceClient = loRaDeviceClient;
        }

        public LoRaDevice Create(IoTHubDeviceInfo deviceInfo)
        {
            return new LoRaDevice(
                deviceInfo.DevAddr,
                deviceInfo.DevEUI,
                this.loRaDeviceClient
            );
        }
    }
}