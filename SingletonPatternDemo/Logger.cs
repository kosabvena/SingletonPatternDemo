using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatternDemo
{
    public sealed class Logger
    {
        private static readonly Lazy<Logger> _instance =
            new Lazy<Logger>(() => new Logger());

        private readonly List<string> _entries = new List<string>();
        private int _callCount = 0;

        private Logger()
        {
            _entries.Add($"[{DateTime.Now:HH:mm:ss}] Logger создан (единственный экземпляр).");
        }

        public static Logger Instance => _instance.Value;

        public void Log(string message)
        {
            _callCount++;
            _entries.Add($"[{DateTime.Now:HH:mm:ss}] (вызов #{_callCount}) {message}");
        }

        public string GetLog()
        {
            var sb = new StringBuilder();
            foreach (var entry in _entries) sb.AppendLine(entry);
            return sb.ToString();
        }

        public int CallCount => _callCount;
    }
}