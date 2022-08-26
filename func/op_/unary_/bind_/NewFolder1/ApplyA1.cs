using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{

	public abstract class ApplyA1<TInput, TFunc>
		: _invoke_.InputA<TInput>
		,
		_invoke_.FuncI<TFunc>
		where TInput: nilnul.obj._expr_.BlankI
		where TFunc: nilnul.obj._func_.BlankI

	{
		public ApplyA1(TInput body, TFunc func) : base(body)
		{
			_func = func;
		}

		private TFunc _func;
		public TFunc func => _func;

		public override string ToString()
		{
			return $"{input}|>{_func}"; // like the "|>" in F#
		}
	}
}
