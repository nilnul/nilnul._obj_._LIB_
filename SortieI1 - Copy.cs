using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._sortie_;
using nilnul.obj.str.be_.distinct.vow;
using nilnul.objs.be_.distinct;
using nilnul.objs.be_.distinct.vow;

namespace nilnul.obj
{
	
	
	public interface SortieI3<T>
		:
		
		nilnul.obj.ISortie
	
	{
		nilnul.objs.be_.distinct.vow.Ee<T> objs { get; }

	}



	[Serializable]
	//[SettingsSerializeAs(SettingsSerializeAs.Binary)]

	public class Sortie3<T> :
		nilnul.objs.be_.distinct.vow.Ee<T>
		,
		SortieI3<T>
	{
		public Sortie3(IEqualityComparer<T> eq, ObjsI3<T> val) : base( eq,val)
		{
		}

		public Sortie3( ObjsI3<T> val) : base(EqualityComparer<T>.Default , val)
		{
		}

		public Sortie3(IEqualityComparer<T> eq, IEnumerable<T> val) : base(
			eq
			,
			(val)
		)
		{
		}

		public Sortie3( IEnumerable<T> val) : base(
			EqualityComparer<T>.Default
			,
			(val)
		)
		{
		}


		public Sortie3(IEqualityComparer<T> eq, params T[] elements) : base(eq, elements)
		{
		}

		public Sortie3( params T[] elements) : base(EqualityComparer<T>.Default, elements)
		{
		}

		/// <summary>
		/// Parameterless constructor may be required for deserialization.
		/// </summary>
		public Sortie3(): base(EqualityComparer<T>.Default)
		{

		}

		public objs.be_.distinct.vow.Ee<T> objs => this;
	}




}
