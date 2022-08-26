using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_.byConversing_
{
	/// <summary>
	/// used to judge another cumulator which is the converse of the original.
	/// </summary>
	public class BeDefault<T,TBe>
		:
		ByConversing<T>
		//where TBe: nilnul.obj.BeI1<CumulatorI<T>>,new()
		where TBe: binary.cumulator.Be_opGeneriI<T>,new()

	{
		public BeDefault() : base(
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}


		static public BeDefault<T,TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault<T,TBe>>.Instance;
			}
		}




	}
}
