using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._sortie_;
using nilnul.obj.str.be_.distinct.vow;
using nilnul.objs.be_.distinct.vow;

namespace nilnul.obj.sortie_
{


	[Serializable]
	//[SettingsSerializeAs(SettingsSerializeAs.Binary)]
	public class EqDefault1<T, TEq> :
		nilnul.obj.Sortie3<T>
		

		where TEq : IEqualityComparer<T>, new()
	{


		public EqDefault1( ObjsI3<T> val) : base(
			_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
			,
			val
		)
		{
		}

		public EqDefault1( IEnumerable<T> val) : base(
			_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
			,
			val
		)
		{
		}

		public EqDefault1( params T[] elements) : base(
			_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
			, elements)
		{
		}

		/// <summary>
		/// required for deserialization
		/// </summary>
		public EqDefault1():base(
_obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TEq>.Instance
			)
		{

		}
	}

	



}
