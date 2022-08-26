using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.eq_
{
	/// <summary>
	/// </summary>
	/// <typeparam name="TKey"></typeparam>
	/// <typeparam name="TVal"></typeparam>
	/// <typeparam name="TEq"></typeparam>
	public class ElEqDefault<T, TEq>
		: nilnul.obj.matrix.Eq<T>
		where TEq : IEqualityComparer<T>, new()
	{
		

		public ElEqDefault() : base(nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance)
		{
		}


		static public ElEqDefault<T, TEq> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<ElEqDefault<T, TEq>>.Instance;
			}
		}

	}
}
