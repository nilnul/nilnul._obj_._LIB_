using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.border_.lower
{
	public class Phrase<T>
		: nilnul.obj.border.PhraseI<
			T
		>
	{
		public string phrase(BorderI<T> obj)
		{
			return $"{(obj.openFalseCloseTrue?"[":"(" )}{obj.mark}";
		}


		static public Phrase<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Phrase<T>>.Instance;
			}
		}

	}
}
