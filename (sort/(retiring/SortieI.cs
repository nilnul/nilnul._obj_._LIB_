using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.objs.be_.distinct.vow;

namespace nilnul.obj
{
	
	/// 
	[Obsolete()]
	public interface SortieI<T>:SortieI,_sortie_.AsDistinct<T>
	{


	}
	[Obsolete()]

	public class Sortie<T> :
		nilnul.obj.Box<nilnul.objs.be_.distinct.vow.En1<T>>
		,
		SortieI<T>
	{
		public Sortie(objs.be_.distinct.vow.En1<T> val) : base(val)
		{
		}

		public objs.be_.distinct.vow.En1<T> asDistinct => this.boxed;
	}
	[Obsolete()]

	public interface SortieI<T, TEq>
		:_sortie_.AsDistinct<T,TEq>
		,SortieI
		where TEq:IEqualityComparer<T>,new()
	{
	}

	[Obsolete()]
	public class Sortie<T, TEq> :
		nilnul.obj.Box<
			nilnul.objs.be_.distinct.vow.En1<T, TEq>
		>
		,
		SortieI<T, TEq>
		where TEq : IEqualityComparer<T>, new()
	{
		public Sortie(objs.be_.distinct.vow.En1<T, TEq> val) : base(val)
		{
		}

		public objs.be_.distinct.vow.En1<T, TEq> asDistinct => this.boxed;
	}


}
