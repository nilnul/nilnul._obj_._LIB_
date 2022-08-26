using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func.input_
{
	public interface SortieI:nilnul.obj.var._sortie_.BlankI, _func._input_.BlankI
	{
	}

	public class Sortie<TSortie>
		:
		nilnul.obj.Box<TSortie>
		,
		SortieI
		where TSortie:nilnul.obj.var._sortie_.BlankI
	{
		public Sortie(TSortie val) : base(val)
		{
		}
	}
}
