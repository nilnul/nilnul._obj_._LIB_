using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tups.tbl.phrase_
{
	 public class CelSepByTab
	{
		public IEnumerable<string> lines(DataView table)
		{
			yield return rec.phrase_._ByTabX.PhraseAsRow(
				table.Table.Columns.Cast<DataColumn>().Select(c => c.ColumnName)
			);


			foreach (var item in
				tups.phrase_._ByTabX.Lines(

				table.Cast<DataRowView>()
				))
			{


				yield return item;
			}

		}
	}


}
