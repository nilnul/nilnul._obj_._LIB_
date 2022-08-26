using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func_
{
	[Obsolete("" /*nameof(InputI)*/)]
	public interface  ParsI<out T>
		where T:nilnul.obj.var._sortie_.BlankI
	{
		T pars { get; }
	}

	[Obsolete(/*nameof(InputI<TPars>)*/)]

	public class Pars<TPars> 
		: 
		ParsI<TPars>
		where TPars : nilnul.obj.var._sortie_.BlankI
	{
		private TPars _pars;
		public TPars pars
		{
			get
			{
				return _pars;
				//throw new NotImplementedException();
			}
		}

		public Pars(TPars pars)
		{
			_pars = pars;
		}
	}
}
