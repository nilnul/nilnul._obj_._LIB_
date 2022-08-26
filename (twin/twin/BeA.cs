using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.twin
{

	public interface BeI<T, TTwin>
		:
		nilnul.obj.BeI1<TTwin>
		where TTwin: obj.TwinI<T>
	{

	}

	public interface BeI<T> :
		BeI<T, TwinI<T>>
		{ }



	public  class Be<T, TCo>
		:
		nilnul.obj.Be<TCo>
		,
		twin.BeI<T,TCo>
		where TCo : nilnul.obj.TwinI<T>
	{
		public Be(Func<TCo, bool> func) : base(func)
		{
		}

		
	}

	public abstract class BeOnReA<T, TCo>
		:
		nilnul.obj.ReI<T>
		,
		twin.BeI<T,TCo>
		where TCo : nilnul.obj.TwinI<T>
	{
		public bool be(TCo obj)
		{
			return re(obj.component, obj.component1);
		}
		public abstract bool re(T a, T b);
	}

	public abstract class BeOnReA<T>
	:
		BeOnReA<T,TwinI<T>>
		
	{
		
	}




}
