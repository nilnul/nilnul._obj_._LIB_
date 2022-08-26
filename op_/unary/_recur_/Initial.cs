using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary._recur_
{
	public interface InitialI<T>
	{
		/// <summary>
		/// 
		/// </summary>
		/// <remarks>
		/// <see cref="nameof(nilnul.obj.op_.binary._cumulator_.InitialI)"/>
		/// </remarks>
		T initial { get; }
	}

	public abstract class InitialA<T>:InitialI<T>
	{
		private T _initial;

		public T initial
		{
			get { return _initial; }
			set { _initial = value; }
		}

		public InitialA(T initial0)
		{
			_initial = initial0;
		}


	}
}
