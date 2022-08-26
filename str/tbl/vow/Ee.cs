using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.tbl.vow
{
	public class Ee : nilnul.obj.vow.Ee1<DataTable>
	{
		public Ee(DataTable val, VowI2<DataTable> vow) : base(val, vow)
		{
		}
	}
}
