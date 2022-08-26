using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.started_
{
	public class FroArray<T> :
		nilnul.obj.Box<List<T>>,
		obj.str_.StartedI<T>
	{

		public FroArray(List<T> list):base(list)
		{
			obj.AssertX.True(
				list.Any()	
			);
		}


		public T head
		{
			get
			{
				return boxed.First();
			//	throw new NotImplementedException();
			}
		}

		public StrI<T> tail
		{
			get
			{
				return obj.str_._FroList<T>.FroList( boxed.Skip(1).ToList());
				//throw new NotImplementedException();
			}
		}
	}
}
