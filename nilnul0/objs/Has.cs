using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{

	public class Has<T> : nilnul.objs._eq.ElEq<T>
	{
		public Has(IEqualityComparer<T> elEq) : base(elEq)
		{
		}

		public bool has(nilnul.ObjsI2<T> objs, T obj) {
			return _has(objs.toArr(), obj);
		}

		public bool _has(IEnumerable<T> objs, T obj) {
			return objs.Contains(obj,elEq);
		}

	}
	public class Has<T,TEq> :Has<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public Has():base(nilnul.obj.SingletonByDefault<TEq>.Instance)
		{

		}

		static public Has<T,TEq> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Has<T,TEq>>.Instance;
			}
		}

	}

	
}
