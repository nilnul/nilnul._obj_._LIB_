using nilnul.objs_._started_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{


	[Obsolete()]
	public class Started4<T,TBody>
		: StartedA1<T, nilnul.ObjsI3<T>>
		,
		nilnul.obj.str_.SeqI3<T>
		,
		StartedI
		


	{
		//ObjsI3<T> TailI<ObjsI3<T>>.tail => new Objs_arr<T>(this.tail );


		public Started4(T head, ObjsI3<T> tail) : base(head, tail)
		{
		}
		public Started4(T head, IEnumerable<T> tail) :
			this(
				head
				,
				new Objs_arr<T>( tail )
			)
		{
		}

		public Started4(IEnumerable<T> seq):this(seq.First(),seq.Skip(1))
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			yield return this.head;
			foreach (var item in this.tail)
			{
				yield return item;
			}
		}

		

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}



}
