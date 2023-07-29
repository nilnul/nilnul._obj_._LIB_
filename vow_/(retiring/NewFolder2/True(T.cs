using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow_
{
	[Obsolete(nameof(bit.vow_.True<TException>))]
	public class True<TException> : 
		
		VowI<bool>

		where TException:Exception,new()
	{


		private None<TException> _none;

		public None<TException> none
		{
			get { return _none; }
			set { _none = value; }
		}


		public True(TException xpn)
		{
			_none = new None<TException>(xpn);
		}
		public void vow(bool obj)
		{
			if (!obj)
			{
				_none.vow( );
			}
 		}

	}
}
