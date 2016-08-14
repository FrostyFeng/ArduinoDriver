﻿namespace ArduinoLibCSharp.ArduinoUploader.ArduinoSTK500Protocol.Messages
{
    internal class ReadSignatureResponse : Response
    {
        public bool IsCorrectResponse
        {
            get { return Bytes.Length == 4 && Bytes[3] == CommandConstants.CommandConstants.Resp_STK_OK; }
        }

        public byte[] Signature
        {
            get {  return new[] { Bytes[0], Bytes[1], Bytes[2] }; }
        }
    }
}
