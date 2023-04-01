using System.Collections.Generic;
using System.Linq;

namespace nilnul.obj.str.re_
{
	public class Equisize<T>
		:
		nilnul.obj.str_.seq.ReI<T>
	{
		public bool re(IEnumerable<T> a, IEnumerable<T> b)
		{
			return a.Count() ==b.Count(); //exception is the bot type, a subtype of all types;
		}


		static public Equisize<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Equisize<T>>.Instance;
			}
		}

	}
}
