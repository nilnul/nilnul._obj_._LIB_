using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.set.re_
{
	[Obsolete()]
	public static   class _Subset
		

	{

		static public bool Subset<T,TEq>( this Set_eqDefault<T,TEq> a, Set_eqDefault<T,TEq> b)
		where TEq:IEqualityComparer<T>,new()

		{

			return a.hashSet.IsSubsetOf(b.hashSet);

		}


		static public bool Subset<T >( this IEnumerable<T> a, IEnumerable<T> b
			,
			IEqualityComparer<T> elementEq
			)
 
		{

			return a.All( x=>b.Contains(x,elementEq)  ) ;

		}

		
		[Obsolete(nameof(Vow))]
		static public void Avow<T,TEq>(
			
			Set_eqDefault<T,TEq> a,

			Set_eqDefault<T,TEq> b
			
		)
		where TEq : IEqualityComparer<T>, new()

		{

			nilnul.Assert1.True(Subset(a, b));
		}


	
	static public void Vow<T,TEq>(
			
			Set_eqDefault<T,TEq> a,

			Set_eqDefault<T,TEq> b
			
		)
		where TEq : IEqualityComparer<T>, new()

		{

			nilnul.obj.vow_.True.Vow(Subset(a, b));
		}


		
	}
}

