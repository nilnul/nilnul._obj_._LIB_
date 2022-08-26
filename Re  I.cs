using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public interface ReI<T, T1>
		:
		IRe<T,T1>

	{

		bool re(T a,T1 b);

	}


	public interface ReI<T>
		:
		ReI<T,T>
		,
		ReI

	{
	}




	public interface ReI1:ReI<object> {

	}






	public class Re<T> :
		nilnul.obj.Box1<Func<T, T, bool>>
		,
		ReI<T>
	{
		public Re(Func<T, T, bool> val) : base(val)
		{
		}

		public bool re(T a, T b)
		{
			return boxed(a, b);
			//throw new NotImplementedException();
		}
	}

}
