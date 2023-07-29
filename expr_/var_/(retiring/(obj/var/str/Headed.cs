using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var.str
{
	public partial class Headed
	{
		private _var.VarI_dynamicTyped _head;

		public _var.VarI_dynamicTyped head
		{
			get { return _head; }
			set { _head = value; }
		}


		private _str.Enumerable_ofVarWithType _tail;

		public _str.Enumerable_ofVarWithType tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

	}
}
