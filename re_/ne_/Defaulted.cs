using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.ne_
{
	public class Defaulted<T, TEq>
		:
		nilnul.obj.re_.Ne<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public Defaulted()
			:
		base(
			_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
		)
		{
		}

		static public Defaulted<T, TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Defaulted<T, TEq>>.Instance;
			}
		}

	}
}
