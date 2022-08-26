using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.var.set;

namespace nilnul.obj.var.comparer_
{
	public class FroNaming
		: nilnul.Box1<nilnul.obj.var.set.NamingContext>
		,
		ComparerI

	{
		public FroNaming(var.set.NamingContext val) : base(val)
		{
		}

		public FroNaming():this(var.set.NamingContext.Instance)
		{

		}


		/// <summary>
		///those unnamed should be placed first or last.
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>

		public int Compare(nilnul.obj.VarI1 x, nilnul.obj.VarI1 y)
		{
			return nilnul.obj.name.Comparer.Lazy.Compare ( boxed.getEnsuredName(x),
				
				boxed.getEnsuredName(y));
			 
		}


		static private Lazy<FroNaming> _Lazy = new Lazy<FroNaming>();
		static public FroNaming Lazy
		{
			get
			{
				return _Lazy.Value;
			}
		}

	}
}
