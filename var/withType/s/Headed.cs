using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.withType.s
{
	public partial class Headed :SI
	{
		private VarI _head;

		public VarI head
		{
			get { return _head; }
			set { _head = value; }
		}

		private SI _tail;

		public SI tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		public Headed(VarI head, SI tail)
		{
			_head = head;
			_tail = tail;

		}



		public IEnumerator<VarI> GetEnumerator()
		{
			yield return head;
			foreach (var item in _tail)
			{
				yield return item;
			}
			yield break;
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
