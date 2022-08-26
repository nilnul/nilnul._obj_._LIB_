using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow
{
	/// <summary>
	/// vowed objects.'cuz vow is generally derived from be, so vowed is infact been. we get "en" from been; and en is different from but mnemorically related to "ed" in op-ed objects.
	/// </summary>
	///

	public interface EeI<T>:_ee_.EeI<T>
	{
	}



	[Obsolete()]
	public class Ee<T, TVow>
		:
		nilnul.obj.Box<T>
		,
		EeI<T>
		where TVow : nilnul.obj.VowI<T>
	{
		public Ee(T val,TVow vow) : base( val)
		{
			vow.vow(boxed);
		}

		public T ee => boxed;

		static public implicit operator T(Ee<T, TVow> ee)
		{
			return ee.ee;
		}
	}


}
