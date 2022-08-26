using nilnul.obj.be.vow_.xpN_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{



	public class En4<T>
	:
	nilnul.obj.vow.Ee1<T, nilnul.obj.be.Vow4<T>>

	{
		

		public En4(T obj,   nilnul.obj.BeI1<T> be) : base(obj, new be.Vow4<T>(be) )
		{
		}

		public En4(T obj, Predicate<T> predicate):base(obj, new Vow4<T>(predicate) )
		{

		}

		public En4(T obj, Func<T,bool> predicate):base(obj, new Vow4<T>(predicate) )
		{

		}


	}

	

}
