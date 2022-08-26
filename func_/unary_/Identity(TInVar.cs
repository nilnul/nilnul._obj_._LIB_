using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	/// <summary>
	/// abstraction from expr
	/// </summary>
	/// <typeparam name="TInVar"></typeparam>
	/// <typeparam name="TInExpr"></typeparam>
	///
	[Obsolete()]
	public partial class Identity<TInVar>
		:
		FuncI<TInVar,Nullary<TInVar>>
	{
		private obj.VarI3<TInVar> _var;

		public obj.VarI3<TInVar> var
		{
			get { return _var; }
			set { _var = value; }
		}

		
		public Identity(obj.VarI3<TInVar> var)
		{
			_var = var;

		}

		public nilnul.obj.expr.ExprI<TInVar> expr {
			get {
			return new nilnul.obj.expr.Var<TInVar>(_var);
		}  }


		public override string ToString()
		{
			return string.Format("{0}{1}{2}",_var,FuncX.GoesTo,expr);
		}

		public  VarAsFunc<TInVar> ret
		{
			get {
				return new VarAsFunc<TInVar>(_var);
				
				throw new NotImplementedException(); 
			}
		}

		

		public  Nullary<TInVar> apply(expr.ExprI<TInVar> arg)
		{
			return new Nullary<TInVar>( arg);
			throw new NotImplementedException();
		}

	
		

		public  HashSet<VarI1> boundVars
		{
			get {
				return new HashSet<VarI1>(new []{_var} );
				throw new NotImplementedException(); 
			}
		}




		Nullary<TInVar> RetI<Nullary<TInVar>>.ret
		{
			get { throw new NotImplementedException(); }
		}

		public void substitute<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
		{

			throw new NotImplementedException();
		}

		public void reduce()
		{
			return;
			throw new NotImplementedException();
		}

		public FuncI<TInVar, Nullary<TInVar>> substitute2new<TArg>(VarI3<TArg> var, expr.ExprI<TArg> expr)
		{

			throw new NotImplementedException();
		}

		public FuncI<TInVar, Nullary<TInVar>> reduce2new()
		{
			return this;
			throw new NotImplementedException();
		}
	}
}
