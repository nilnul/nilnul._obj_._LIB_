using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.re_
{

	static public class _MultibleX
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static public bool Re<T>(T[,] a, T[,] b)
		{
			return a.GetLength(1) == b.GetLength(0);
		}


	}
	public class Multible<T>
		: nilnul.obj.matrix.ReI<T>
	{
		public bool re(T[,] a, T[,] b)
		{
			return _MultibleX.Re(a, b);
		}


		static public Multible<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Multible<T>>.Instance;
			}
		}

	}
}
