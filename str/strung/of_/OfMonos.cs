using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung.of_
{
	public class OfMonos<T>
		: strung.OfI<T, IEnumerable<T>>
	{
		public IEnumerable<IEnumerable<T>> op(IEnumerable<T> par)
		{
			return par.Select(p=>new[] { p});
			//throw new NotImplementedException();
		}


		static public OfMonos<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<OfMonos<T>>.Instance;
			}
		}

	}
}
