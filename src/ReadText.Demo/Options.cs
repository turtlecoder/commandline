using System;

namespace ReadText.Demo
{
    [Verb("head", HelpText = "Display first lines of a file.")]
    class HeadOptions
    {
        [Option('n', "lines",
                DefaultValue = 10,
                SetName = "amount",
                HelpText = "Lines to be printed from the beginning of the file (default 10).")]
        public uint Lines { get; set; }

        [Option('c', "bytes",
                SetName = "amount",
                HelpText = "Bytes to be printed from the beginning of the file.")]
        public uint Bytes { get; set; }
    }
}