using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.tbl.be.vow_
{
	public class BeDefaulted<TBe> : nilnul.obj.be.vow_.BeDefaulted4<DataTable, TBe>
		,
		nilnul.objs.tbl.VowI
		where TBe : nilnul.obj.BeI1<DataTable>,new()
	{
		
	}
}
