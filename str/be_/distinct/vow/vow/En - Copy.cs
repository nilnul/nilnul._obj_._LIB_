using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.distinct.vow
{
	public class En<T> 
		: 
		nilnul.obj.vow.En<nilnul.obj.StrI1<T>>

	{

		public En( IEqualityComparer<T> eq, nilnul.obj.StrI1<T> val)
			:
			base(
				new nilnul.obj.str.be_.distinct.Vow<T>(eq)
				,
				val
			)
		{
		}
	}

	public class En<T, TEq> 
		: 
		nilnul.obj.vow.En<nilnul.obj.StrI1<T>>

		where TEq : IEqualityComparer<T>,new()
	{

		public En( IEqualityComparer<T> eq, nilnul.obj.StrI1<T> val)
			:
			base(
				new nilnul.obj.str.be_.distinct.Vow<T,TEq>()
				,
				val
			)
		{
		}
	}


	public class En_str<T, TStr> 
		: 
		nilnul.obj.vow.En<TStr>

		where TStr : nilnul.obj.StrI1<T> //, nilnul.obj._str_.ToArrI<T>
	{
		public En_str( IEqualityComparer<T> eq, TStr val)
			:
			base(
				new nilnul.obj.str.be_.distinct.Vow_str<T,TStr>(eq)
				,
				val
			)
		{
		}
	}


	public class En<T, TEq, TStr> 
		: 
		nilnul.obj.vow.En<TStr>

		where TStr : nilnul.obj.StrI1<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public En(  TStr val)
			:
			base(
				new nilnul.obj.str.be_.distinct.Vow<T,TEq,TStr>()
				,
				val
			)
		{
		}
	}






}
