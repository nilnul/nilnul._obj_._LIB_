using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func_.input_
{
	public interface SortieI<out T>
		: InputI<T>
		where T :
		nilnul.obj._func.input_.SortieI
		//,
		//nilnul.obj.var._sortie_.BlankI  //for sortie, as (x, y) =>x+y is x=>y=>x+y whileas (y,x) => x+y is y=>x=>x+y

	{
	}

	public class Sortie<TInput>
:
SortieI<TInput>
		where TInput :
		nilnul.obj._func.input_.SortieI
	{
		private TInput _input;
		public TInput input
		{
			get
			{
				return _input;
				//throw new NotImplementedException();
			}
		}

		public Sortie(TInput input)
		{
			_input = input;
		}
	}


}
