using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var
{
	[Obsolete()]
	public interface SetI<T,  TVar>
		:
		nilnul.obj.SetI2<
			TVar
		>
	{

	}

	[Obsolete()]
	public interface SetI<  T>
		:
		SetI<T,nilnul.obj.VarI5<T>>
		,
		nilnul.obj.SetI2<
			nilnul.obj.VarI5<T>
		>

	{

	}



	[Obsolete()]
	public class Set< T>:

		nilnul.obj.Set2<nilnul.obj.VarI5<T>>


		//HashSet<nilnul.obj.VarI5<T>>
		,
		SetI<T>

	{

		public Set():base(nilnul.obj.var.Eq1.Instance)
		{

		}

		public Set(IEnumerable<nilnul.obj.VarI5<T>> vars):base(vars ) 
		{

		}

		public Set(params VarI5<T>[] boxed):this( (IEnumerable<nilnul.obj.VarI5<T>>)boxed )
		{
		}
	}
}
