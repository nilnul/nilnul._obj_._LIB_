using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda.vow.ee_
{
	public class VowDefault< TVow>
		: Ee
		where TVow : func.calc_.lamda.VowI, new()
	{

		

		public VowDefault(LambdaExpression val) : base(
			val
			,
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}
}
