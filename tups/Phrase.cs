using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tups
{
	static public class _PhraseX
	{
		static public IEnumerable< string> Lines(IEnumerable<IEnumerable<object>> table) {
			
			foreach (var item in table)
			{

				yield return rec._PhraseX.PhraseAsRow(item);
			}

		}

		static public IEnumerable<string> Lines(IEnumerable<DataRow> table)
		{


			foreach (var item in table)
			{

				yield return rec._PhraseX.PhraseAsRow(item.ItemArray);
			}

		}
		static public IEnumerable<string> Lines(IEnumerable<DataRowView> table)
		{


			foreach (var item in table)
			{

				yield return rec._PhraseX.PhraseAsRow(item);
			}

		}

	}


}
