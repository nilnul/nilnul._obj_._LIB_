using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.vow.ee_
{
	public class VowNeo<T, TVow>
		:
		vow.Ee<T>
		where
		TVow : nilnul.obj.VowI2<T[,]>, new()
	{
		public VowNeo(T[,] val) : base(val,

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance

			)
		{
		}
	}
}
