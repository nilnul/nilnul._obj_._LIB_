using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.twin
{
	public interface BandI<out T,in TTwin>
		where TTwin: obj.TwinI<T>
	{
		T band(TTwin co);
	}


	public abstract class BandA<T, TTwin>
		:
		BandI<T, TTwin>
		,
		obj.CombineI1<T>

		where TTwin: obj.TwinI<T>
	{
		public T band(TTwin co) {
			return combine(co.component,co.component1);
		}
		public abstract T combine(T arg, T arg1);
	}
}
