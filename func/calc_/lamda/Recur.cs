using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda
{

	delegate T Recursive<T>(Recursive<T> self);

	public class RecurX
	{


		// We can now apply the self application
		public static Recursive<int> lambda = f => f(f);

		static public void Test()
		{

			lambda(lambda);  // Infinite recursion.

		}



		delegate Func<T1, T2> Recursive<T1, T2>(Recursive<T1, T2> r);

		// The Y Combinator
		static Func<T1, T2>    Y<T1, T2>(Func<Func<T1, T2>, Func<T1, T2>> f)
		{
			Recursive<T1, T2> rec =
				r		//Recursive<T1,T2> r
				=>		//expects Func<T1,T2>
				a		//T1
				=>		//expects T2
				f(	
					r(r)	//Func<T1,T2>
				)		//resulting Func<T1,T2>
				(
					a
				)		//resulting T2
				;


			return rec(rec);	//Func<T1,T2>
		}

		// The Fixed Point Generator
		static Func<long, long> fact = Y<long, long>(
			f		//Func<T1,T2>
				=>		//expects Func<T1,T2>
					n	//T1
						=>	//expects T2
						n > 1 ? 
							n 
								* 
							f(n - 1)	//T2, namely, long 
							:
							1	//T2, namely, longg
		);

		//



	}
}
