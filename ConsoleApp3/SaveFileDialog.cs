using System;

namespace ConsoleApp3
{
    internal class SaveFileDialog
    {
        public SaveFileDialog()
        {
        }

        public bool CreatePrompt { get; internal set; }
        public string InitialDirectory { get; internal set; }
        public string Title { get; internal set; }
        public bool OverwritePrompt { get; internal set; }
        public string Filter { get; internal set; }

        internal void ShowDialog() => throw new NotImplementedException();

    }
}