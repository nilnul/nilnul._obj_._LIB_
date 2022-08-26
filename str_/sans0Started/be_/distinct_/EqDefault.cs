using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.sans0Started.be_.distinct_
{

	public class EqDefault<T,  TEq>
		: 
		Distinct<T >
		where TEq : IEqualityComparer<T>, new()
	{
		public EqDefault() : base(nilnul.obj_.singleton_.Lazy<TEq>.Instance)
		{
		}
	}


	public class EqDefault<T,  TEq, TStr>
		: 
		Distinct<T,TStr >
		

		where TEq : IEqualityComparer<T>, new()
		where TStr: nilnul.obj.str_.Sans0StartedI<T>
	{
		public EqDefault() : base(nilnul.obj_.singleton_.Lazy<TEq>.Instance)
		{
		}

		
	}



}
