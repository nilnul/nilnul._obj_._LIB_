using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tups_.table
{
	/*
	 https://datatracker.ietf.org/doc/html/rfc4180
	 */
	static public class _PhraseX
	{
		static public IEnumerable< string> Lines(DataTable table) {
			yield return rec._PhraseX.PhraseAsRow(
				table.Columns.Cast<DataColumn>().Select(c => c.ColumnName)
			);
			foreach (var item in table.Rows.Cast<DataRow>())
			{

				yield return rec._PhraseX.PhraseAsRow(item.ItemArray);
			}

		}
	}

	public class PhraseAsLines

	{
		 public IEnumerable< string> lines(DataView table) {
			yield return rec._PhraseX.PhraseAsRow(
				table.Table.Columns.Cast<DataColumn>().Select(c => c.ColumnName)
			);
			foreach (var item in table.Cast<DataRowView>())
			{

				yield return rec._PhraseX.PhraseAsRow(item);
			}

		}

	}
}
