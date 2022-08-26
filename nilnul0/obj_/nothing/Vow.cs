using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj_.nothing
{
	public class Vow :
		nilnul.obj.VowA<object>

	{


		public override void vow<X>(object obj, X x)
		{
			nilnul.obj.vow_.True.Singleton.vow(obj  is null, x);


		}





		static public Vow Singleton
		{
			get
			{
				return nilnul._obj.Singleton<Vow>.Instance;
			}
		}
	}

}
