using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	static public class SetX
	{
		static public string Phrase(HashSet<string> set) {

			return $"{{{ nilnul.obj.str.to_._txt.Extensions.ToTxt(set)}}}";

		}

		static public bool NotContain<T>(this HashSet<T> set, T el) {
			return !set.Contains(el);
		}

		static public bool NotContain<T>(this _set_.ContainI<T> set, T el) {
			return !set.contain(el);
		}

	}
}
