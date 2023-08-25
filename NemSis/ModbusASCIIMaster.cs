using System;
using System.IO.Ports;

namespace NemSis
{
    internal class ModbusASCIIMaster
    {
        private string modbusComPort;
        private int modbusBaudrate;
        private int modbusDataBits;
        private StopBits modbusStopBits;
        private Parity modbusParity;

        public ModbusASCIIMaster(string modbusComPort, int modbusBaudrate, int modbusDataBits, StopBits modbusStopBits, Parity modbusParity)
        {
            this.modbusComPort = modbusComPort;
            this.modbusBaudrate = modbusBaudrate;
            this.modbusDataBits = modbusDataBits;
            this.modbusStopBits = modbusStopBits;
            this.modbusParity = modbusParity;
        }

        internal void WriteSingleCoil(byte modbusSlaveAddress, int v1, bool v2)
        {
            throw new NotImplementedException();
        }

        internal void Connection()
        {
            throw new NotImplementedException();
        }

        internal void Disconnection()
        {
            throw new NotImplementedException();
        }
    }
}