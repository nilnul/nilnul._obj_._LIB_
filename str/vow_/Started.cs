using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.vow_
{
	public class Started<T> : nilnul.objs.VowI<T>
	{
		public void vow(IEnumerable<T> obj)
		{
			nilnul.bit.vow_._TrueX.Vow(
				obj.Any()
				,
				new _started.NoneException(
					$"{obj} should not be none."
				)
			);
			//throw new NotImplementedException();
		}


		static public Started<T> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Started<T>>.Instance;
			}
		}

	}
}
