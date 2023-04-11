using System;

namespace nilnul.obj.vow
{
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
