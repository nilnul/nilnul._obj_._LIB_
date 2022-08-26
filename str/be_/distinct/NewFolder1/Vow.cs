using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.be_.distinct
{
	[Obsolete()]
	public class Vow<T> : 
		nilnul.obj.Box<IEqualityComparer<T>>,
		
		nilnul.obj.VowI<nilnul.ObjsI2<T>>
	{
		public Vow(IEqualityComparer<T> equalityComparer):base(equalityComparer)
		{
			be = new Distinct<T>(boxed);
		}

		public nilnul.objs.be_.Distinct<T> be;

		public void vow(ObjsI2<T> obj)
		{
			nilnul.obj.vow_.True.Singleton.vow( be.be(obj) );
			//throw new NotImplementedException();
		}


	}

	[Obsolete()]
	public class Vow<T,TEq>:Vow<T>
		where TEq:IEqualityComparer<T>,new()
	{

		public Vow():base( nilnul.obj.SingletonByDefault<TEq>.Instance )
		{

		}

		static public Vow<T,TEq> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Vow<T,TEq>>.Instance;
			}
		}

	}
}
