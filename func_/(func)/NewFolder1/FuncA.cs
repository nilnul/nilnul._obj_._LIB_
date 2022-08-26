using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{


	public abstract class FuncA<TPars, TRule>
		:
		_func_.Pars<TPars>
		,
		_func_.BodyI<TRule>
		where TPars : nilnul.obj.var._sortie_.BlankI        //.SortieI
		where TRule : nilnul.obj._expr_.BlankI
	{
		public FuncA(TPars pars) : base(pars)
		{
		}

		private TRule _body;
		public TRule body => _body;

		public override string ToString()
		{
			return $"{pars}=>{_body}";
		}
	}

}