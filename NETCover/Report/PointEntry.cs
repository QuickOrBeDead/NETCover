//
// PointEntry.cs
//
// Author:
//   Sergiy Sakharov (sakharov@gmail.com)
//
// (c) 2017 NET Cover Contributors
// (C) 2009 Sergiy Sakharov
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace NETCover.Report
{
	public class PointEntry
	{
		public PointEntry(uint line, int col, uint endLine, int endCol, string document, bool instrumented)
		{
			VisitCount = 0;

			Excluded = !instrumented;
			Line = line;
			Column = col;
			EndLine = endLine;
			EndColumn = endCol;
			Document = document;
		}

		public int VisitCount { get; set; }
		public uint Line { get; set; }
		public int Column { get; set; }
		public uint EndLine { get; set; }
		public int EndColumn { get; set; }
		public bool Excluded { get; set; }
		public string Document { get; set; }

		public string GetXml()
		{
			return string.Format(
				@"<seqpnt visitcount=""{0}"" line=""{1}"" column=""{2}"" endline=""{3}"" endcolumn=""{4}"" excluded=""{5}"" document=""{6}"" />",
				VisitCount,
				Line,
				Column,
				EndLine,
				EndColumn,
				Excluded.ToString().ToLower(),
				Document
				);
		}
	}
}
