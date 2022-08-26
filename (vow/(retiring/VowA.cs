using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public abstract class VowA<T> :
		VowI1<T>
	{

		public abstract void vow<X>(T obj, X x )
			where X:Exception
			;



		public void vow(T obj, string x) {
			vow<Exception>(obj,new Exception(x));
		}
		public void vow(T obj) {
			vow(obj,"");
		}
	}
}
