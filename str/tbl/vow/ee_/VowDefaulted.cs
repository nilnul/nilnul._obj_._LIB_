using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.tbl.vow.ee_
{
	public class VowDefaulted<TVow> : tbl.vow.Ee
		where TVow: tbl.VowI,new()
	{
		public VowDefaulted(DataTable val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
