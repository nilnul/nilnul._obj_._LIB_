using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.vow.ee_
{
	public class VowNeo_ofIn<T, TVow>
		:
		Ee_ofIn<T>
		where TVow : obj.VowI_ofIn<(T, T)>, new()
	{
		public VowNeo_ofIn(in (T, T) val) : base(in val,
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}

		public VowNeo_ofIn((T, T) val) : this ( in val)
		{
		}

	
		//public VowNeo_ofIn(in T x, in T y) : this( in  (x, y) )
		//{
		//}  ///error
		public VowNeo_ofIn(in T x, in T y) : this(  (x, y) )
		{
		}

		public VowNeo_ofIn(in T x, T y) : this(in x, in y)
		{
		}
		public VowNeo_ofIn( T x, in T y) : this(in x, in y)
		{
		}
		public VowNeo_ofIn(T a, T b) : this( in a, b)
		
		{
		}



	}
}
