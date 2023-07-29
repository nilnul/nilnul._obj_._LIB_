using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.vow_.ofIn.ee_
{
	public class VowDefault<T, TVow>
		:
		Ee<T>
		where TVow : obj.VowI_ofIn<(T, T)>, new()
	{
		public VowDefault(in (T, T) val) : base(in val,
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}

		public VowDefault((T , T) b) : this(
			in b
		)
		{
		}
		public VowDefault(T a, T b) : this(
			 (a,b)
		)
		{
		}
	}
}
