using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.avow_
{
	[Obsolete()]
	public class True : _avow_.AvowI<bool>
	{
		public void avow(bool obj)
		{
			if (!obj)
			{
				nilnul._AvowX.Fail( );
			}
 		}

		static public void Avow(bool obj) {
			if (!obj)
			{
				nilnul._AvowX.Fail( );
			}

		}
	}
}
