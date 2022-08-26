using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.vow.ee_
{


	

	public class VowNeo<T,  TVow>
		: nilnul.obj.str.vow.Ee1<T>
		where TVow : nilnul.obj.VowI2<IEnumerable<T>>, new()
	{


		public VowNeo(IEnumerable<T> val
			)
			:
		base(
				val
			,
nilnul._obj.typ_.nilable_.unprimable_.Singleton<TVow>.Instance

		)
		{
		}
	}

}
