using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.distinct.vow.ee_
{


	public class EqDefault<T, TEq>
		:
		Ee<T>

		where TEq : IEqualityComparer<T>, new()
	{

		public EqDefault(nilnul.obj.StrI2<T> val)
			:
			base(
				nilnul.obj_.singleton_.Lazy<TEq>.Instance
				,
				val
			)
		{
		}
	}




	public class EqDefault<T, TEq, TStr>
		:
		Ee<T, TStr>

		where TStr : nilnul.obj.StrI2<T>
		where TEq : IEqualityComparer<T>, new()
	{
		public EqDefault(TStr val)
			:
			base(
					nilnul.obj_.singleton_.Lazy<TEq>.Instance
				,
				val
			)
		{
		}
	}






}
