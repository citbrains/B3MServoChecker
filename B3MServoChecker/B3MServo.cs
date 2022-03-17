using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using Extensions.Collections;

namespace B3MServoChecker
{
    class B3MServo
    {
        public B3MServo(SerialPort serialPort)
        {
            _serialPort = serialPort;
        }

        public bool servoOn(byte servoID)
        {
            ByteList cmd = new ByteList();
            byte[] rx = new byte[5];
            byte mode = ((byte)B3MLib.B3MLib.Options.ControlPosition | (byte)B3MLib.B3MLib.Options.RunNormal);

            cmd.Bytes = B3MLib.B3MLib.WriteSingle(0, B3MLib.B3MLib.SERVO_TORQUE_ON, servoID, new byte[] { mode });
            return B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx);
        }

        public bool servoOff(byte servoID)
        {
            ByteList cmd = new ByteList();
            byte[] rx = new byte[5];
            byte mode = ((byte)B3MLib.B3MLib.Options.ControlPosition | (byte)B3MLib.B3MLib.Options.RunFree);

            cmd.Bytes = B3MLib.B3MLib.WriteSingle(0, B3MLib.B3MLib.SERVO_TORQUE_ON, servoID, new byte[] { mode });
            return B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx);
        }

        public bool setFFMode(byte servoID)
        {
            ByteList cmd = new ByteList();
            byte[] rx = new byte[5];
            byte mode = ((byte)B3MLib.B3MLib.Options.ControlFForward | (byte)B3MLib.B3MLib.Options.RunNormal);

            cmd.Bytes = B3MLib.B3MLib.WriteSingle(0, B3MLib.B3MLib.SERVO_TORQUE_ON, servoID, new byte[] { mode });
            return B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx);
        }

        public bool setAngleWithPosControl(byte servoID, double angle_deg)
        {
            ByteList cmd = new ByteList();
            byte[] rx = new byte[7];
            int angle_deg100 = (int)(angle_deg * 100);

            cmd.Bytes = B3MLib.B3MLib.SetPosision(0, servoID, angle_deg100, 0);
            return B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx);
        }

        public bool setAngle(byte servoID, double angle_deg)
        {
            ByteList cmd = new ByteList();
            byte[] rx = new byte[5];
            int angle_deg100 = (int)(angle_deg * 100);
            byte[] angle_bytes = BitConverter.GetBytes(angle_deg100);

            cmd.Bytes = B3MLib.B3MLib.WriteSingle(0x00, B3MLib.B3MLib.SERVO_DESIRED_POSITION, servoID, angle_bytes);
            return B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx);
        }

        public bool getAngle(byte servoID, ref double angle_deg)
        {
            ByteList cmd = new ByteList();
            byte[] rx = new byte[7];

            cmd.Bytes = B3MLib.B3MLib.Read(0x00, B3MLib.B3MLib.SERVO_CURRENT_POSITION, 2, servoID);
            if (B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx) == false) return false;
            angle_deg = (double)((short)Extensions.Converter.ByteConverter.ByteArrayToInt16(rx[4], rx[5]))/100;
            return true;
        }

        public bool setPWM(byte servoID, double duty)
        {
            ByteList cmd = new ByteList();
            byte[] rx = new byte[5];
            byte PWM_ADDRESS = 0x2A;
            short duty_short = (short)(duty * 1);
            byte[] duty_bytes = BitConverter.GetBytes(duty_short);

            cmd.Bytes = B3MLib.B3MLib.WriteSingle(0x00, PWM_ADDRESS, servoID, duty_bytes);
            B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx);
            return true;
        }

        public bool getPWM(byte servoID, ref double duty)
        {
            ByteList cmd = new ByteList();
            byte[] rx = new byte[7];
            byte PWM_ADDRESS = 0x4C;

            cmd.Bytes = B3MLib.B3MLib.Read(0x00, PWM_ADDRESS, 2, servoID);
            if (B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx) == false) return false;
            duty = (double)Extensions.Converter.ByteConverter.ByteArrayToInt16(rx[4], rx[5]);
            return true;
        }

        public bool getCurrent(byte servoID, ref double current_mA)
        {
            ByteList cmd = new ByteList();
            byte[] rx = new byte[7];
            byte CURRENT_ADDRESS = 0x48;

            cmd.Bytes = B3MLib.B3MLib.Read(0x00, CURRENT_ADDRESS, 2, servoID);
            B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx);
            current_mA = (double)Extensions.Converter.ByteConverter.ByteArrayToInt16(rx[4], rx[5])/1000;
            return true;
        }

        public bool setGain(byte servoID, double kp, double kd, double ki)
        {
            ByteList cmd = new ByteList();
            byte[] rx = new byte[5];
            ulong kp100 = (ulong)(kp * 100);
            byte[] kp_bytes = BitConverter.GetBytes(kp100);
            cmd.Bytes = B3MLib.B3MLib.WriteSingle(0x00, B3MLib.B3MLib.CONTROL_KP0, servoID, kp_bytes);
            B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx);
            ulong kd100 = (ulong)(kd * 100);
            byte[] kd_bytes = BitConverter.GetBytes(kd100);
            cmd.Bytes = B3MLib.B3MLib.WriteSingle(0x00, B3MLib.B3MLib.CONTROL_KD0, servoID, kd_bytes);
            B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx);
            ulong ki100 = (ulong)(ki * 100);
            byte[] ki_bytes = BitConverter.GetBytes(ki100);
            cmd.Bytes = B3MLib.B3MLib.WriteSingle(0x00, B3MLib.B3MLib.CONTROL_KI0, servoID, ki_bytes);
            B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx);
            byte[] static_bytes = BitConverter.GetBytes(0);
            cmd.Bytes = B3MLib.B3MLib.WriteSingle(0x00, B3MLib.B3MLib.CONTROL_STATIC_FRICTION0, servoID, static_bytes);
            B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx);
            byte[] dynamic_bytes = BitConverter.GetBytes(0);
            cmd.Bytes = B3MLib.B3MLib.WriteSingle(0x00, B3MLib.B3MLib.CONTROL_DYNAMIC_FRICTION0, servoID, dynamic_bytes);
            B3MLib.B3MLib.Synchronize(_serialPort, cmd.Bytes, ref rx);
            return true;

        }

        private SerialPort _serialPort;
    }

}
