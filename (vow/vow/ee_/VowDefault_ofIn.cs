using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow.ee_
{



	public class VowDefault_ofIn<T, TVow>
		:
		vow.Ee_ofIn<T,TVow>
		
		where TVow : nilnul.obj.VowI_ofIn<T>,new()
	{
		public VowDefault_ofIn(in T val) :
			base( in val
				,

				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance

			)
		{
		}

		public VowDefault_ofIn( T val) :
			this( in val
				

			)
		{
		}


		
	}


}
