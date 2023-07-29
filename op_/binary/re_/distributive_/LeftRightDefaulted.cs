using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.re_.distributive_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TOp"></typeparam>
	public class LeftRightDefaulted<T, TOp, TLeftDistri, TRightDistri>
		: nilnul.obj.op_.binary.re_.DistributiveI<T, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>
		where TLeftDistri : re_._distributive.LeftDistributiveI<T, TOp>, new()
		where TRightDistri : re_._distributive.RightDistributiveI<T, TOp>, new()
	{
		public bool re(TOp plus, TOp multi)
		{
			return nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TLeftDistri>.Instance.re(plus,multi)
				&&
nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TRightDistri>.Instance.re(plus,multi)
				;
		}


		static public LeftRightDefaulted<T, TOp, TLeftDistri, TRightDistri> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<LeftRightDefaulted<T, TOp, TLeftDistri, TRightDistri>>.Instance;
			}
		}

	}


}
