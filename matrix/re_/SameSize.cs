using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.re_
{

	/// <summary>
	/// 
	/// </summary>
	/// alias:
	///		plusable
	///		overlap
	///		equisize
	///		
	static public class _SameSizeX
	{
		static public bool Re<T>(T[,] a, T[,] b)
		{
			return a.GetLength(0) == b.GetLength(0) && a.GetLength(1) == b.GetLength(1);
			//throw new NotImplementedException();
		}


	}
	public class SameSize<T>
		: nilnul.obj.matrix.ReI<T>
	{
		public bool re(T[,] a, T[,] b)
		{
			return a.GetLength(0) == b.GetLength(0) && a.GetLength(1) == b.GetLength(1);
			//throw new NotImplementedException();
		}


		static public SameSize<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<SameSize<T>>.Instance;
			}
		}

	}
}
