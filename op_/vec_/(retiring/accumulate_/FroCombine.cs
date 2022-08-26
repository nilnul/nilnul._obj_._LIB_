using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.accumulate_
{
	public class FroCombine<T> :
		nilnul.obj.AccumulateA<T>
		,
		nilnul.obj.AccumulateI<T>
	{
		private nilnul.obj.CombineI<T> _combine;

		public nilnul.obj.CombineI<T> combine
		{
			get { return _combine; }
			//set { _combine = value; }
		}

		private T _unit;

		public T unit
		{
			get { return _unit; }
			//set { _unit = value; }
		}


		public FroCombine(nilnul.obj.CombineI<T> combine, T unit)
		{
			_combine = combine;
			_unit = unit;

		}

		public override T eval(IEnumerable<T> arg)
		{
			
				return arg.Any()? _combine.eval(arg.First(), eval(arg.Skip(1))):_unit;
			
			//throw new NotImplementedException();
		}
	}
	public class FroCombine<T, TCombine>
		: FroCombine<T>
		where TCombine : nilnul.obj.CombineI<T>,nilnul.obj._combine_.UnitI<T>, new()
	{
		public FroCombine() : base(SingletonByDefault<TCombine>.Instance, SingletonByDefault<TCombine>.Instance.unit)
		{
		}
	}
}
