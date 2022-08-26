using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.co.vow.ee_
{
	public class VowNeo<T, TVow>
		:
		vow.Ee<T>
		where
		TVow : nilnul.obj.VowI_ofIn<(T[,],T[,]) >, new()
	{
	

		public VowNeo(in (T[,], T[,]) val)
			: base(
				  val,
 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}

		

		public VowNeo((T[,], T[,]) val) : base(val, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{
		}

	

		public VowNeo(in T[,] x,in T[,] y) : base(in x,in y, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{
		}

		public VowNeo(in T[,] x, T[,] y) : base(in x, y, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{
		}

		public VowNeo( T[,] x,in T[,] y) : base( x,in y, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{
		}
		public VowNeo( T[,] x, T[,] y) : base( in x,in y, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{
		}

	
	
	}
}
