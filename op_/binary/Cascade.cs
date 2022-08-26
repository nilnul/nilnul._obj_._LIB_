using nilnul.obj.op_.binary._cascader_;
using nilnul.objs_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary
{
	public interface CascaderI<out T, out TOp>
		:
		_cumulator_.BinderI<TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>
	{
	}
	public interface CascaderI< T>
		 : CascaderI<T, nilnul.obj.op_.BinaryI<T>>
	{
	}

	public class Cascader<T, TOp>
		:
		nilnul.objs_.started.CascadeA<T>,
		CascaderI<T, TOp>
		,
		nilnul.objs_.started.CascadeI<T>

		where TOp : nilnul.obj.op_.BinaryI<T>
	{
		
		private TOp _binder;
		public TOp binder { get { return _binder; } }
		public Cascader( TOp binder)
		{
			_binder = binder;
		}
		



		public override T cascade(Started3<T> started)
		{
			return _cascader_._CascadeX.Cascade_ofStarted(
				started
				,binder
			);
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
		Cascader<T, nilnul.obj.op_.BinaryI<T>>
		,
		CascaderI<T>
	{

		public Cascader( nilnul.obj.op_.BinaryI<T> accumulator) : base( accumulator)
		{

		}

	}



}
