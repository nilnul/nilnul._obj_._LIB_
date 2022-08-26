using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.avow_
{
	[Obsolete(nameof(nilnul.obj.aver_.False))]
	public class False : _avow_.AvowI<bool>
	{
		public void avow(bool obj)
		{
			if (obj)
			{
				nilnul._AvowX.Fail( );
			}
 		}

		static public void Avow(bool obj) {
			if (obj)
			{
				nilnul._AvowX.Fail( );
			}

		}
	}
}
