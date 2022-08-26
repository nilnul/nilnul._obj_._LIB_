using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// the asserted value. the assertion is derived from a be.
	/// </summary>
	/// 
	[Obsolete()]
	public interface EnI<T,Be>
		:nilnul.obj.avow._ed_.EdI<T>
		where Be:BeI<T>

	{

	}
	[Obsolete()]

	public interface EnI<T> :EnI<T,BeI<T>>
	{ }
	[Obsolete()]

	public class En<T, TBe>
		: 
		nilnul.obj.avow.Ed<T>
		,
		
		EnI<T, TBe>
		where TBe : BeI<T>
	{

		public En( T val, TBe be) :base(
			 val, new nilnul.obj.be.Avow1<T>(be)
			)
		{

		}


	}
	[Obsolete()]

	public class En<T> :
		nilnul.obj.avow.Ed<T>
		,
		
		EnI<T>
	{
		public En(BeI<T> be, T val):base(
			val,
			new nilnul.obj.be.Avow1<T>(be)	
		)
		{

		}
		
	}
}
