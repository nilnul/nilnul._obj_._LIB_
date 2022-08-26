using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict.be_.bijective.vow
{
	public class Ed<TKey, TVal, TValEq> :

		nilnul.obj.vow.Ed<Dictionary<TKey, TVal>, Vow<TKey, TVal, TValEq>>
		where TValEq:IEqualityComparer<TVal>,new()
	{
		public Ed():this( new Dictionary<TKey, TVal>()  )
		{
		}

		public Ed(Dictionary<TKey, TVal> val) : base(val)
		{
		}

		public override string ToString()
		{
			return nilnul.obj.DictX.Phrase(ed);
		}
	}
}
