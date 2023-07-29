using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary._cumulator_
{

	public abstract class InitialA<T>
		
	{
		private T _initial;
		public T initial { get { return _initial; } }

		
		public InitialA(T initial)
		{
			_initial = initial;
		}
	


	}




}
