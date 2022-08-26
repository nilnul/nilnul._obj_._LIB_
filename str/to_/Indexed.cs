using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.op_.to_
{
	public class Indexed<T>
		:
		nilnul.obj.op_.ToI<
			IEnumerable<(T, int)>
			,
			IEnumerable<T>
		>
	{

		public IEnumerable<(T, int)> op(IEnumerable<T> par)
		{
			return par.Select((x,i) =>(x,i) );
			//throw new NotImplementedException();
		}

		static public Indexed<T> Lazy
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<Indexed<T>>.Instance;
			}
		}
		static public Indexed<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Indexed<T>>.Instance;
			}
		}


	}
}
