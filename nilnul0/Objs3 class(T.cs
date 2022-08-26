using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul
{

	[Obsolete("Seq doesnot gurantee to be finite, use with care")]
	[Serializable]
	public class Objs3<T> :

		nilnul.obj.Box1<IEnumerable<T>>,
		nilnul.ObjsI3<T>
	{
		public Objs3(IEnumerable<T> val) : base(val)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return boxed.GetEnumerator();
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			//throw new NotImplementedException();
		}
	}


}
