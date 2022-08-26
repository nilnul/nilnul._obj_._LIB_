using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.tbl.be_
{
	public class RowsAny : tbl.BeI
	{
		public bool be(DataTable obj)
		{
			return tbl._RowsX.Seq_byCast(obj).Any();
		}

		static public RowsAny Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<RowsAny>.Instance;
			}
		}

	}
}
