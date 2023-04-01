using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.comp
{
	
	static public class _ReX
	{

		static public bool Le<T>(this IComparer<T> _ord, T x, T y) {
			return _ord.Compare(x, y)<=0;
		}

		static public bool Ge<T>(this IComparer<T> _ord, T x, T y) {
			return Le(_ord, y, x);

		}
		static public bool Eq<T>(this IComparer<T> _ord, T x, T y)
		{
			return _ord.Compare(x, y) == 0;
		}

		static public bool Ne<T>(this IComparer<T> _ord, T x, T y) {
			return _ord.Compare(x,y) !=0;
		}

		static public bool Lt<T>(this IComparer<T> _ord, T x, T y) {
			return _ord.Compare(x,y)<0;
		}

		static public bool Gt<T>(this IComparer<T> _ord, T x, T y) {
			return _ord.Compare(x,y)>0;

		}
	

	}
}