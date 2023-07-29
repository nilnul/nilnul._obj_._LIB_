using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.rec
{
	public class _PhraseX
	{


	

		static public string PhraseAsRow(IEnumerable<string> s, string sep=",")
		{

			return string.Join(sep, s.Select(
				i => nilnul.txt.phrase_._AsCelX.AsCel(i)
			));
		}

		static public string PhraseAsRow(IEnumerable<object> s, string sep=",")
		{

			return PhraseAsRow(s.Select(i=>i.ToString()),sep);
		}

		static public string PhraseAsRow(DataRow s, string sep=",")
		{

			return PhraseAsRow(s.ItemArray,  sep);
		}

		static public string PhraseAsRow(DataRowView s, string sep=",")
		{

			return PhraseAsRow(s.Row,  sep);
		}


	}

	public abstract class PhraseA
		:
		nilnul.obj.PhraseI<
			IEnumerable<string> 
		>
		,
		nilnul.obj.PhraseI<
			IEnumerable<object> 
		>
		,
		nilnul.obj.PhraseI<
			DataRow
		>
		,
		nilnul.obj.PhraseI<
			DataRowView
		>
		
	{
		public abstract string phrase(IEnumerable<string> s);

		 public string phrase(IEnumerable<object> s)
		{

			return phrase(s.Select(i=>i.ToString()));
		}

		 public string phrase(DataRow s)
		{

			return phrase(s.ItemArray);
		}

		 public string phrase(DataRowView s)
		{

			return phrase(s.Row);
		}
	}


}
