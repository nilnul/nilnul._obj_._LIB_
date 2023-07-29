using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.tups.tbl
{
	/*
	 https://datatracker.ietf.org/doc/html/rfc4180
	 */
	/// <summary>
	/// 
	/// </summary>
	static public class _PhraseX
	{
		static public IEnumerable< string> Lines(DataTable table, string sep4cels=",") {
			yield return rec._PhraseX.PhraseAsRow(
				table.Columns.Cast<DataColumn>().Select(c => c.ColumnName)
				,
				sep4cels
			);
			foreach (var item in table.Rows.Cast<DataRow>())
			{

				yield return rec._PhraseX.PhraseAsRow(item.ItemArray,sep4cels);
			}

		}
	}

	public class PhraseAsLines

	{
		 public IEnumerable< string> lines(DataView table, string sep4cels=",") {
			yield return rec._PhraseX.PhraseAsRow(
				table.Table.Columns.Cast<DataColumn>().Select(c => c.ColumnName)
				,
				sep4cels
			);
			foreach (var item in table.Cast<DataRowView>())
			{

				yield return rec._PhraseX.PhraseAsRow(item, sep4cels);
			}

		}

	}
}
