using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.vow
{
	[Obsolete()]
	public interface EdI_beUnspecified<T>
		:nilnul.obj.vow._ed_.VowedI<T>

	{ }
	/// <summary>
	/// the asserted value. the assertion is derived from a be.
	/// </summary>
	/// <remarks>
	/// ed, unlike "be.vow", can be placed under the namespace "nilnul.T.vow" in that:
	///		* ed is based on vow, not matter what "vow" , be it "be.vow" or "T.vow"
	///			in contract, be.vow is constructed using "be".
	/// </remarks>
	/// 
	[Obsolete()]
	public interface EdI<T,Be>
		:
		//nilnul.obj.avow._ed_.EdI<T>
		//,
		EdI_beUnspecified<T>
		where Be:BeI<T>

	{

	}
	[Obsolete()]

	public interface EdI<T> :EdI<T,BeI<T>>
	{ }
	[Obsolete()]

	public class Ed<T, TBe>
		: 
		nilnul.obj.vow.Ed<T>
		,
		
		EdI<T, TBe>
		where TBe : BeI<T>
	{

		public Ed( T val, TBe be) :base(
			 val, new nilnul.obj.be.Vow<T>(be)
			)
		{

		}


	}
	[Obsolete()]

	public class Ed_beDefaultable<T, TBe>
	:
	Ed<T,TBe>

	where TBe : BeI<T>,new()
	{

		public Ed_beDefaultable(T val) : base(
			 val, SingletonByDefault<TBe>.Instance
			)
		{

		}


	}
	[Obsolete()]

	public class Ed<T> :
		nilnul.obj.vow.Ed<T>
		,
		
		EdI<T>
	{
		public Ed(BeI<T> be, T val):base(
			val,
			new nilnul.obj.be.Vow<T>(be)	
		)
		{

		}
		
	}
}
