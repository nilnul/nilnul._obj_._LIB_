using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow_
{
	public class False : VowI<bool>
	{
		private nilnul.obj.vow_.None _none;

		public nilnul.obj.vow_.None none
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
		public void vow(bool obj)
		{
			if (obj)
			{
				_none.vow();
			}
 		}

		static public void Vow(bool obj) {
			if (obj)
			{
				nilnul.obj.vow_.None.Vow( );
			}

		}


		static public False Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<False>.Instance;
			}
		}


		public static void Vow(bool v1, string v2)
		{
			if (v1)
			{
				nilnul.obj.vow_.None.Vow(v2 );
			}

			//throw new NotImplementedException();
		}
	}
}
