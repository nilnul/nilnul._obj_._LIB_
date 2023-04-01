using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{


	/// <summary>
	/// one element at the beginning, called head.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TTail"></typeparam>
	/// <seealso cref="IFrugal{T}"/>,

	public class StartedA1<T, TTail>
		: _started_.HeadA<T>
		,_started_.TailI<TTail>
	{
	

		public StartedA1(T head, TTail tail) : base(head)
		{
			_tail = tail;

		}

		private TTail _tail;

		public TTail tail
		{
			get
			{
				return _tail;
				//throw new NotImplementedException();
			}
			set {
				_tail = value;
			}
		}
	}



}
