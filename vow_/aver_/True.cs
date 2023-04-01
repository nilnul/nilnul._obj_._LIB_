using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.aver_
{
	public class True : _aver_.AverI<bool>
	{

		public void aver(bool obj)
		{
			if (!obj)
			{
				nilnul.obj.aver_.None.Aver( );
			}
 		}



		static public void Aver(bool obj) {
			if (!obj)
			{
				nilnul.obj.aver_.None.Aver( );
			}

		}
		static public void Aver(bool obj,Exception exception) {
			if (!obj)
			{
				nilnul.obj.aver_.None.Aver(exception );
			}

		}


	}
}
