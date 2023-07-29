using nilnul.obj.op_.binary._cascader_;
using nilnul.objs_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_.binary
{
	public interface CascaderI< T>
		 : CascaderI<T, nilnul.obj.of_.BinaryI<T>>
	{
	}

	public class Cascader<T, TOp>
		:
		nilnul.obj.str_.started.CascadeA<T>
		,
		CascaderI<T, TOp>
		,
		nilnul.obj.str_.started.CascadeI<T>

		where TOp : nilnul.obj.of_.BinaryI<T>
	{
		
		private TOp _binder;
		public TOp binder { get { return _binder; } }
		public Cascader( TOp binder)
		{
			_binder = binder;
		}

		public override T cascade(T started, IEnumerator<T> seq)
		{
			while (seq.MoveNext())
			{
				started = _binder.op(started, seq.Current);
			}
			return started;
	
		
		}


		//public T cascade(IEnumerable<T> seq)
		//{
		//	return cascade(new Started3<T>( seq ));
		//}
		//public T cascade(params T[] seq)
		//{
		//	return cascade((IEnumerable<T>) seq);
		//}
	}

	public class Cascader<T>
		:
		Cascader<T, nilnul.obj.of_.BinaryI<T>>
		,
		CascaderI<T>
	{

		public Cascader( nilnul.obj.of_.BinaryI<T> accumulator) : base( accumulator)
		{

		}

	}



}
