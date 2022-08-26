using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.converse_
{
	public class OpDefault<T, TOp>
		: Converse<T>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
	{
		public OpDefault() : base(nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TOp>.Instance)
		{
		}



		static public OpDefault<T, TOp> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<OpDefault<T, TOp>>.Instance;
			}
		}


	}
}
