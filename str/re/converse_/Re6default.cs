using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.re.converse_
{
	public class Re6default<TEl,TRe>
		:
		Converse<TEl>
		where TRe: obj.ReI<IEnumerable<TEl>>,new()
	{
		public Re6default() : base(
			 nilnul._obj.typ_._UnisonX<TRe>.Unison
		)
		{
		}

		static public Re6default<TEl,TRe> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Re6default<TEl,TRe>>.Unison;
			}
		}

	}
}
