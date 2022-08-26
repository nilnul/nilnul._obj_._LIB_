using nilnul.obj.str_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{

	public class Disown<T> : nilnul.objs._eq.ElEq<T>
	{
		public Disown(IEqualityComparer<T> elEq) : base(elEq)
		{
		}

		public bool disown(nilnul.ObjsI2<T> objs, T obj) {
			return _disown(objs.toArr(), obj);
		}

		public bool disown(List<T> objs, T obj) {
			return _disown(objs, obj);
		}


		public bool _disown(IEnumerable<T> objs, T obj) {
			return !objs.Contains(obj,elEq);
		}

	}
	public class Disown<T,TEq> :Has<T>
		where TEq:IEqualityComparer<T>,new()
	{
		public Disown():base(nilnul.obj.SingletonByDefault<TEq>.Instance)
		{

		}

		static public Disown<T,TEq> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Disown<T,TEq>>.Instance;
			}
		}

	}

	
}
