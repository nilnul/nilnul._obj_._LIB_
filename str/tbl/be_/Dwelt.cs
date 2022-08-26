using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.tbl.be_
{
	/// <summary>
	/// at least one col,onerow
	/// </summary>
	public class Dwelt
		: nilnul.objs.tbl.BeI
	{
		public bool be(DataTable obj)
		{
			return obj.Columns.Count>0 && RowsAny.Singleton.be(obj);
		}

		static public Dwelt Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Dwelt>.Instance;
			}
		}

	}
}
