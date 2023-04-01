using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow.ee_
{



	public class VowNeo_byRef<T, TVow>
		:
		vow.Ee_byRef<T,TVow>
		
		where TVow : nilnul.obj.Vow_ofRefI<T>,new()
	{
		public VowNeo_byRef(ref T val) :
			base( ref val
				,

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance

			)
		{
		}

		public VowNeo_byRef( T val) :
			this( ref val
				

			)
		{
		}


		
	}


}
