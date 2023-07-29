using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dict_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TEq"></typeparam>
	/// <see cref="nilnul.rel_.dict"/>
	/// alias:
	///		sel:<see cref="obj.set.ISel"/>
	///		,
	///		select
	///		, subset,
	///		sub
	///		
	public class Poll<T,TEq>:Poll<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public Poll():base(nilnul._obj.Singleton<TEq>.Instance)
		{

		}

		public Poll(IDictionary<T,bool> dict):base(dict, nilnul._obj.Singleton<TEq>.Instance)
		{

		}
	}
}
