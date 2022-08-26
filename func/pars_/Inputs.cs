using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.inputs
{
	public partial interface InputI
	{
		Type type { get; }

	}
	public partial class Input<T> : InputI
	{
		public Input()
		{

		}

		public Type type
		{
			get
			{
				return typeof(T);
				throw new NotImplementedException();
			}
		}
	}


	public partial interface InputsI : IEnumerable<InputI>
	{


	}
	public class None:InputsI
	{


		public IEnumerator<InputI> GetEnumerator()
		{
			yield break;
			
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			yield break;

		}
	}

	public class Headed<T>:InputsI
	{

		private Input<T> _head;

		public Input<T> head
		{
			get { return _head; }
			set { _head = value; }
		}
		private InputsI _tail;

		public InputsI tail
		{
			get { return _tail; }
			set { _tail = value; }
		}
		
		

		public Headed(Input<T> head, InputsI tail  )
		{
			this._head = head;
			_tail = tail;

		}

		public IEnumerator<InputI> GetEnumerator()
		{
			yield return head;
			foreach (var item in tail)
			{
				yield return item;
				
			}


		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}


}
