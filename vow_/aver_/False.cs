using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.aver_
{
	public class False : _aver_.AverI<bool>
	{
		private nilnul.obj.aver_.None _none;

		public nilnul.obj.aver_.None none
		{
			get { return _none; }
			set { _none = value; }
		}


		public False(string exceptionMsg)
		{
			_none = new None(exceptionMsg);
		}

		public False():this("")
		{

		}
		public void aver(bool obj)
		{
			if (obj)
			{
				_none.aver();
			}
 		}

		static public void Aver(bool obj) {
			if (obj)
			{
				nilnul.obj.aver_.None.Aver( );
			}

		}

		public static void Aver(bool v1, string v2)
		{
			if (v1)
			{
				nilnul.obj.aver_.None.Aver(v2 );
			}

			//throw new NotImplementedException();
		}
	}
}
