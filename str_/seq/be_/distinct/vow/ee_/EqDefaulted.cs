using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.be_.distinct.vow.ee_
{


	public class EqDefault<T, TEq, TStr> 
		: 
		nilnul.obj.str_.seq.be_.distinct.vow.Ee<T,TStr>

		where TStr : nilnul.obj.str_.SeqI2<T>

		where TEq:IEqualityComparer<T>,new()
	{
		public EqDefault(  TStr val)
			:
			base(
				nilnul.obj_.singleton_.Lazy< TEq>.Instance
				,
				val
			)
		{
		}
	}



	public class EqDefault<T, TEq>
		:
		nilnul.obj.str_.seq.be_.distinct.vow.Ee<T>

		where TEq : IEqualityComparer<T>, new()
	{

		public EqDefault( nilnul.obj.str_.SeqI2<T>  val)
			:
			base(
				nilnul.obj_.singleton_.Lazy< TEq>.Instance
				,
				val
			)
		{
		}
	}








}
