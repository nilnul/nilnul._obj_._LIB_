using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.stati.s.b
{

	public class Distinct1
: Distinct< SI>

	{

		public new class Asserted : nilnul.enumerable.b.Distinct_eqDefault<obj.var.StatiI, obj.var.Eq, SI>.Asserted
		{
			public Asserted(SI vars) : base(vars)
			{

			}
			public Asserted() : base(obj.var.stati.s.Empty.Singleton)
			{

			}

			


		}
	
	}




	public class Distinct<TSi>
:nilnul.enumerable.b.Distinct_eqDefault<obj.var.StatiI, stati.Eq,TSi>
		where TSi :SI

	{
		static public bool Eval(TSi s) {
			return global::nilnul.enumerable.b.Distinct_eqDefault<obj.var.StatiI, obj.var.Eq>.Singleton.be(s);
		}

		public new class Asserted : nilnul.enumerable.b.Distinct_eqDefault<obj.var.StatiI, obj.var.Eq, TSi>.Asserted
		{
			public Asserted(TSi vars) : base(vars)
			{

			}

			


		}
	}

	public class Distinct
:nilnul.enumerable.b.Distinct_eqDefault<VarI_blank1, obj.var.Eq,SI>

	{
		static public bool Eval(SI s) {
			return global::nilnul.enumerable.b.Distinct_eqDefault<VarI_blank1, obj.var.Eq>.Singleton.be(s);
		}

		public new class Asserted: nilnul.enumerable.b.Distinct_eqDefault<VarI_blank1, obj.var.Eq,SI>.Asserted
		{
			public Asserted(SI vars):base(vars)
			{
			}
		}
	}
}
