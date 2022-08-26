using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tups.phrase_
{
	static public class _ByTabX
	{
		static public IEnumerable< string> Lines(IEnumerable<IEnumerable<object>> table) {
			
			foreach (var item in table)
			{

				yield return rec.phrase_._ByTabX.PhraseAsRow(item);
			}

		}

		static public  string Txt(IEnumerable<IEnumerable<object>> table) {

			return string.Join(
				Environment.NewLine
				,
				Lines(table)
			);


		}

		static public IEnumerable<string> Lines(IEnumerable<DataRow> table)
		{
			

			foreach (var item in table)
			{

				yield return rec.phrase_._ByTabX.PhraseAsRow(item);
			}

		}
		static public IEnumerable<string> Lines(IEnumerable<DataRowView> table)
		{
			

			foreach (var item in table)
			{

				yield return rec.phrase_.ByTab.Singleton.phrase(item);
			}

		}

		static public  string Txt(IEnumerable<DataRow> table) {

			return string.Join(
				Environment.NewLine
				,
				Lines(table)
			);


		}

	}
}
