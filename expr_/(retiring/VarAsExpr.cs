using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.var.stati;

namespace nilnul.expr
{
	[Obsolete()]
	public interface VarAsExprI:ExprI {

	}


	[Obsolete()]
	public class VarAsExpr_TInVar<TInVar>
		:
		VarAsExpr<nilnul.VarI1<TInVar> , var.Set_ofVarI>,
		
		nilnul.ExprI<TInVar>
		
		,VarAsExprI
	{
		

		

		public VarAsExpr_TInVar(nilnul.VarI1<TInVar> var):base(var)
		{
		}

		public nilnul.expr.VarAsExpr_TInVar<TInVar> reduce()
		{

			return this;
			throw new NotImplementedException();
		}

		public ExprI<TInVar> substitute<V>(VarI1<V> var, ExprI<V> expr)
		{
			if (this.var==var)
			{

				return expr as ExprI<TInVar>;
			}
			else
			{
				return this;
			}

			throw new NotImplementedException();
		}
		public override string ToString()
		{
			return var.ToString();
		}
	}

	[Obsolete()]
	public class VarAsExpr<TVar,TVarSet>
		:
	 VarAsExpr<TVar>

		where TVar :VarI1
		where TVarSet:var.SetI,new()
	{
		

		public TVarSet vars
		{
			get
			{
				return new TVarSet() { this.var };
				throw new NotImplementedException();
			}
		}


		public VarAsExpr(TVar var):base(var)
		{
		}

	
		
	}

	[Obsolete()]
	public class VarAsExpr1<TVar,TVarSet>
		:
	 VarAsExpr<TVar>

		where TVar :VarI1
		where TVarSet:var.SetI<TVar>,new()
	{
		

		public TVarSet vars
		{
			get
			{
				return new TVarSet() { this.var };
				throw new NotImplementedException();
			}
		}


		public VarAsExpr1(TVar var):base(var)
		{
		}

	
		
	}

	[Obsolete()]
	public class VarAsExpr<TVar>
		:
	 VarAsExprI
		//where TVar :VarI1
	{
		private TVar _var;

		public TVar var
		{
			get { return _var; }
			set { _var = value; }
		}

		



		public VarAsExpr(TVar var)
		{
			_var = var;
		}

	
		
		public override string ToString()
		{
			return _var.ToString();
		}
	}
}
