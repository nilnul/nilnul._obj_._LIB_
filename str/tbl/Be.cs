using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.tbl
{
	public interface BeI:nilnul.obj.BeI1<DataTable>
	{
	}
	public class Be :
		nilnul.obj.Be1<DataTable>
		,
		BeI
	{
		public Be(Func<DataTable, bool> func) : base(func)
		{
		}
	}
}
