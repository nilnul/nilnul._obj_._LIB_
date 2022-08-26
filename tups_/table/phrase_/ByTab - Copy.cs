using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tups_.table.phrase_
{
	static public class _CelSepByTabX
	{
		static public IEnumerable<string> Lines(DataTable table)
		{
			yield return rec.phrase_._ByTabX.PhraseAsRow(
				table.Columns.Cast<DataColumn>().Select(c => c.ColumnName)
			);


			foreach (var item in
				tups.phrase_._ByTabX.Lines(

				table.Rows.Cast<DataRow>()
				))
			{


				yield return item;
			}

		}
	}


}
