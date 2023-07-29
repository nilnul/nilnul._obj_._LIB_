using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.var
{
	public interface SetI2<T,  TVar>
		:
		nilnul.obj.SetI2<
			TVar
		>
	{

	}

	public interface SetI2<  T>
		:
		SetI2<T,nilnul.obj.VarI6<T>>
		,
		nilnul.obj.SetI2<
			nilnul.obj.VarI6<T>
		>

	{

	}



	public class Set2< T>:

		nilnul.obj.Set2<nilnul.obj.VarI6<T>>


		//HashSet<nilnul.obj.VarI5<T>>
		,
		SetI2<T>

	{

		public Set2():base(nilnul.obj.var.Eq1.Instance)
		{

		}

		public Set2(IEnumerable<nilnul.obj.VarI6<T>> vars):base(vars ) 
		{

		}

		public Set2(params VarI6<T>[] boxed):this( (IEnumerable<nilnul.obj.VarI6<T>>)boxed )
		{
		}
	}
}
