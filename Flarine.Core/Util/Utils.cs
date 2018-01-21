﻿using System;
using System.Linq;
using System.Text;

namespace Flarine.Core.Util
{
    public static class Utils
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static byte[] ToBytes(this string hexString)
        {
            return Enumerable.Range(0, hexString.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(hexString.Substring(x, 2), 16))
                     .ToArray();
        }

        public class Hex
        {
            private readonly byte[] _bytes;
            private readonly int _bytesPerLine;
            private readonly bool _showHeader;
            private readonly bool _showOffset;
            private readonly bool _showAscii;

            private readonly int _length;

            private int _index;
            private readonly StringBuilder _sb = new StringBuilder();

            private Hex(byte[] bytes, int bytesPerLine, bool showHeader, bool showOffset, bool showAscii)
            {
                _bytes = bytes;
                _bytesPerLine = bytesPerLine;
                _showHeader = showHeader;
                _showOffset = showOffset;
                _showAscii = showAscii;
                _length = bytes.Length;
            }

            public static string Dump(byte[] bytes, int bytesPerLine = 16, bool showHeader = true, bool showOffset = true, bool showAscii = true)
            {
                if (bytes == null)
                {
                    return "<null>";
                }
                return (new Hex(bytes, bytesPerLine, showHeader, showOffset, showAscii)).Dump();
            }

            private string Dump()
            {
                if (_showHeader)
                {
                    WriteHeader();
                }
                WriteBody();
                return _sb.ToString();
            }

            private void WriteHeader()
            {
                if (_showOffset)
                {
                    _sb.Append("Offset(h)  ");
                }
                for (int i = 0; i < _bytesPerLine; i++)
                {
                    _sb.Append($"{i & 0xFF:X2}");
                    if (i + 1 < _bytesPerLine)
                    {
                        _sb.Append(" ");
                    }
                }
                _sb.AppendLine();
            }

            private void WriteBody()
            {
                while (_index < _length)
                {
                    if (_index % _bytesPerLine == 0)
                    {
                        if (_index > 0)
                        {
                            if (_showAscii)
                            {
                                WriteAscii();
                            }
                            _sb.AppendLine();
                        }

                        if (_showOffset)
                        {
                            WriteOffset();
                        }
                    }

                    WriteByte();
                    if (_index % _bytesPerLine != 0 && _index < _length)
                    {
                        _sb.Append(" ");
                    }
                }

                if (_showAscii)
                {
                    WriteAscii();
                }
            }

            private void WriteOffset()
            {
                _sb.Append($"{_index:X8}   ");
            }

            private void WriteByte()
            {
                _sb.Append($"{_bytes[_index]:X2}");
                _index++;
            }

            private void WriteAscii()
            {
                int backtrack = ((_index - 1) / _bytesPerLine) * _bytesPerLine;
                int length = _index - backtrack;

                // This is to fill up last string of the dump if it's shorter than _bytesPerLine
                _sb.Append(new string(' ', (_bytesPerLine - length) * 3));

                _sb.Append("   ");
                for (int i = 0; i < length; i++)
                {
                    _sb.Append(Translate(_bytes[backtrack + i]));
                }
            }

            private string Translate(byte b)
            {
                return b < 32 ? "." : Encoding.UTF8.GetString(new[] { b });
            }
        }
    }
}