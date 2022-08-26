using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	/// <summary>
	/// the taxonomy of func classifies according to func's return type
	/// </summary>
	public interface FuncI
	{
		
	}

	public interface FuncI<TPars, TRule>
		:
		FuncI
		,
		_func_.ParsI<TPars>
		,
		_func_.RuleI<TRule>
		where TPars: nilnul.obj.var._sortie_.BlankI		//.SortieI
		where TRule:nilnul.obj.ExprI
	{

	}

	//public class Func2<TPars, TRule>
	//	:
	//	nilnul.obj._func_.Pars<TPars>
	//	,
	//	FuncI<TPars, TRule>
	//	where TPars: nilnul.obj.var._set_.BlankI //.SortieI
	//	where TRule:nilnul.obj.ExprI
	//{
	//	private TRule _rule;

	//	public TRule rule
	//	{
	//		get { return _rule; }
	//		set { _rule = value; }
	//	}

	//	public Func2(TPars pars, TRule rule) : base(pars)
	//	{
	//		_rule = rule;
	//	}
	//}
}