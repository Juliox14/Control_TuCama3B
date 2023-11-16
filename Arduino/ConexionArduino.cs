using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Proyecto___Concentraciones_de_Alcohol.Arduino
{
    internal class ConexionArduino
    {
        
        public ConexionArduino() 
        {
            ArduinoPort = new System.IO.Ports.SerialPort();

            ArduinoPort.PortName = "COM10"; //Checar en su equipo
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.ReadTimeout = 500;
            ArduinoPort.WriteTimeout = 500;

        }
    

        public SerialPort ArduinoPort
        {
            get;
        }


    }
}
