using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.str.be
{
	public class Multiplicable
	{
		static public bool Eval<T>(T[] a, T[] b) {

			return a.Length == b.Length;

		}
	}
}
