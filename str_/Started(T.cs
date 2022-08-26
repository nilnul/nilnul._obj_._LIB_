using nilnul.obj.str_;
using nilnul.objs_._started_;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{


	public class Started5<T>
		: StartedA1<T, nilnul.obj.str_.SeqI3<T>>
		,
		nilnul.obj.str_.SeqI3<T>
		,
		StartedI1<T>
		


	{
		//ObjsI3<T> TailI<ObjsI3<T>>.tail => new Objs_arr<T>(this.tail );


		public Started5(T head, nilnul.obj.str_.SeqI3<T> tail) : base(head, tail)
		{
		}
		public Started5(T head, IEnumerable<T> tail) :
			this(
				head
				,
				new nilnul.obj.str_.Seq3<T>( tail )
			)
		{
		}

		public Started5(IEnumerable<T> seq):this(seq.First(),seq.Skip(1))
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
