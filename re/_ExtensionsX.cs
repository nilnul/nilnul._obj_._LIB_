using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re
{
	static public class _ExtensionsX
	{
		static public bool Re<T,T1>(this nilnul.obj.ReI<T,T1> re, (T,T1) co) {
			return re.re(co.Item1,co.Item2);
		}
		static public bool Re_ovHomo<T>(this nilnul.obj.ReI<T> re, (T,T) co) {
			return re.re(co.Item1,co.Item2);
		}


	}
}
