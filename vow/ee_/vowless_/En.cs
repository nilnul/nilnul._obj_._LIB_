using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._vow_;

namespace nilnul.obj.vow
{
	/// <summary>
	/// vowed objects.'cuz vow is generally derived from be, so vowed is infact been. we get "en" from been; and en is different from but mnemorically related to "ed" in op-ed objects.
	/// </summary>

	[Obsolete()]
	public class En<T>
		:
		EnA<T>
	{
		public En(  VowI<T> vow, T val)
			:base(val)
		{
			vow.vow(val);
		}
	}

	[Obsolete()]

	public class En<T, TVow>
		: En<T>
		where TVow : nilnul.obj.VowI<T>, new()
	{
		public En(T val) : base( nilnul.obj_.Singleton<TVow>.Instance, val)
		{
		}

		static public implicit operator T(En<T, TVow> en) {
			return en.en;
		}
	}

	



}
