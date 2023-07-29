using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.phrase_
{
	public class Three0more<TEl> :
		PhraseI<TEl>
	{
		public string phrase(IEnumerable<TEl> obj)
		{
			var firstFour = obj.Take(4);

			if (firstFour.Count() < 4)
			{
				return $$"""{{{nilnul.objs._PhraseX._Phrase(firstFour)}}}""";
			}
			return $$"""{{{nilnul.objs._PhraseX._Phrase(firstFour.Take(3))}}}, ...""";

		}


		static public Three0more<TEl> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<Three0more<TEl>>.Unison;
			}
		}
			
	}
}
