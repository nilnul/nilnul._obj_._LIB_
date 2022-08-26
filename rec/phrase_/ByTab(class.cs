using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.rec.phrase_
{
	public class ByTab
		: rec.PhraseA
	{



		public override string phrase(IEnumerable<string> s)
		{

			return string.Join("\t", s.Select(
				i => nilnul.txt.phrase_.asCel_.ByTabX.AsCel(i)
			));
		}


		static public ByTab Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ByTab>.Instance;
			}
		}





	}
}
