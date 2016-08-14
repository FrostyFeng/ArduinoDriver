﻿using CommandLine;
using CommandLine.Text;

namespace ArduinoLibCSharp.SketchUploader
{
    internal class CommandLineOptions
    {
      [Option('f', "file", Required = true, HelpText = "Path to the input file (in intel HEX format) which is to be uploaded to the Arduino.")]
      public string FileName { get; set; }
    
      [Option('p', "port", Required = true, HelpText = "Name of the COM port where the Arduino is attached (e.g. 'COM1', 'COM2', 'COM3'...).")]
      public string PortName { get; set; }

      [ParserState]
      public IParserState LastParserState { get; set; }

      [HelpOption]
      public string GetUsage() {
        return HelpText.AutoBuild(this,
          current => HelpText.DefaultParsingErrorsHandler(this, current));
      }
    }
}
