using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_.nilard_
{
	/// <summary>
	/// </summary>
	public class LeftNilardDefault<T,TBe>
		:
		Nilard<T>
		where TBe: binary.cumulator.be_._nilard.semi_.LeftNilardI<T>,new()

	{
		public LeftNilardDefault() : base(
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}


		static public LeftNilardDefault<T,TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<LeftNilardDefault<T,TBe>>.Instance;
			}
		}




	}
}
