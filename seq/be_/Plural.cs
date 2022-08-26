using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.be_
{

	/// <summary>
	/// at least two; may be infinite.
	/// </summary>
	/// <typeparam name="TEl"></typeparam>
	public class Plural<TEl> :
		nilnul.obj.seq.BeI<TEl>
	{
		public bool be(IEnumerable<TEl> obj)
		{
			return obj.Take(2).Count() >= 2;

		}


		static public Plural<TEl> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Plural<TEl>>.Instance;
			}
		}

	}
}
