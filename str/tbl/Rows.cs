using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace nilnul.objs.tbl
{


	static public class _RowsX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="table"></param>
		/// <returns></returns>
		public static IEnumerable<DataRow> Seq_byFilterOfType(DataTable table)
		{
			return table.Rows.AsQueryable().OfType<System.Data.DataRow>();

		}


		/// <summary>
		/// by tbl select
		/// </summary>
		/// <param name="table"></param>
		/// <returns></returns>
		public static DataRow[] Arr(DataTable table)
		{
			return table.Select();

		}

		public static IEnumerable<DataRow> Seq_byCast(DataTable table)
		{
			return table.Rows.Cast<DataRow>();

		}

		public static IEnumerable<DataRow> Seq_byEnum(DataTable table)
		{
			var enumerator = table.Rows.GetEnumerator();
			while (enumerator.MoveNext())
			{
				yield return (DataRow)enumerator.Current;
			}

		}


	}


}
