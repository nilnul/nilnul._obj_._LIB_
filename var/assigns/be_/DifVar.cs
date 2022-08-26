using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.obj.var.assigns.be_
{

	/// <summary>
	/// at most one can be selected from each of the equivalent classes of Assign with the partition of SameVar.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class DifVar<T> :
		nilnul.objs.be_.Diff<Assignment<T>, assign.eq_.SameVar<T>>,

		assigns.BeI<T>
	{

		public class En : be.En<T, DifVar<T>>
		{
			public En(IEnumerable<Assignment<T>> val) : base(val)
			{
			}
		}

	}
}
