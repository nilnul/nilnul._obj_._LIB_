using nilnul.obj.seq.be_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.vow_
{
	public class Empty<T> :
		nilnul.obj.vow_.xpN_.OfHeirA<IEnumerable< T>,Empty<T>>
		,
		nilnul.objs.VowI<T>
	{
		public override void vow(IEnumerable<T> obj)
		{
			nilnul.bit.vow_._TrueX.Vow(
				obj.None()
				,
				new nilnul.obj._vow.FailException1<Empty<T>>
				(
					$"{obj} should be none."
				)
			);
			//throw new NotImplementedException();
		}


		static public Empty<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Empty<T>>.Instance;
			}
		}

	}

	static public class EmptyX
	{
		static public void VowEmpty<T>(this IEnumerable<T> objs) {
			Empty<T>.Singleton.vow(objs);
		}

	}
}
