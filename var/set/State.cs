using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.obj.var.set
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class State<T> : nilnul.obj.var.assigns.be_.DifVar<T>.En
	{
		//public nilnul.obj.var.Set1 _vars;

		public nilnul.obj.var.Set1 vars {
			get {

				return new Set1(
					avowed.Select( varAssign=>varAssign.var )	
				);
			}
		}



		public State(IEnumerable<var.Assignment<T>> val) : base(val)
		{
		}
	}
}
