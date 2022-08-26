﻿using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.txt.phrase_
{
	public class _AsCelX
	{


		static public string AsCel(string input)
		{

			var r = input;
			if (r.Contains(",") || r.Contains('\r') || r.Contains('\n'))
			{
				r = r.Replace("\"", "\"\"");
				return $"\"{r}\"";
			}
			return input;

		}

	
	}
}
