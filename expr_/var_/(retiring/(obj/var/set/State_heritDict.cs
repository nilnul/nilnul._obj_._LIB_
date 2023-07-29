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
	public class State_heritDict<T> : Dictionary<nilnul.obj.VarI5<T>,T>
	{

		public State_heritDict(nilnul.obj.var.Set<T> vars, IEnumerable<T> vals)
		{
			nilnul.obj.avow_.True.Avow( vars.Count == vals.Count());
			for (int i = 0; i < vars.Count; i++)
			{
				Add(vars.ElementAt(i), vals.ElementAt(i));
			}
		}


	}
}
