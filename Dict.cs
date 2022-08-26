using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// the key cannot be null. so the keys is a set.
	/// Whether the val is null is undefined. In other words, it can be null without throwing exception.
	///		For val to be nonNull, see nilnul.rel_.Dict
	/// </summary>
	public interface IDict { }

	//[Obsolete("nilnul.rel_.Dict, in that dict is the relation based on set.")]

	public class Dict<TKey,TVal, TKeyEq>:Dictionary<TKey, TVal>
		,
		IDict
		where TKeyEq:IEqualityComparer<TKey>,new()
	{
		public Dict():base(
			nilnul.obj_.Singleton<TKeyEq>.Instance
		)
		{

		}

		public Dict(IDictionary<TKey,TVal> dict):base(dict)
		{

		}
	}
}
