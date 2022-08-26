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
	public class _ByTabX
	{


	

		static public string PhraseAsRow(IEnumerable<string> s)
		{

			return string.Join("\t", s.Select(
				i => nilnul.txt.phrase_.asCel_.ByTabX.AsCel(i)
			));
		}


		static public string PhraseAsRow(IEnumerable<object> s)
		{

			return PhraseAsRow(s.Select(i=>i.ToString()));
		}

		static public string PhraseAsRow(DataRow  s)
		{

			return PhraseAsRow( s.ItemArray);
		}


	}
}
