using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.be_._commutative
{
	public class OnObjs<T>
		:
		nilnul.obj.Box1<
			IEqualityComparer<T>
		>
		
	{
		public OnObjs(IEqualityComparer<T> val) : base(val)
		{
		}
		public OnObjs():this(EqualityComparer<T>.Default)
		{

		}

		public bool be(BinaryI<T> obj, T par, T par1)
		{
			return boxed.Equals(
				obj.op(par, par1)
				,
				obj.op(par1, par)
			);
		}
		public bool be(BinaryI<T> obj, (T, T) c)
		{
			return be(obj, c.Item1, c.Item2);
			//throw new NotImplementedException();
		}

		public bool be(BinaryI<T> obj, IEnumerable< T>  pars)
		{

			return nilnul.obj.str.combinate_._CoupleDownX.CoupleDown_byMove(pars).All(
				c=> be(obj,c) 
			);


			
			for (int i = 0; i < pars.Count(); i++)
			{
				for (int j = i+1; j < pars.Count(); j++)
				{
					if (!be(obj,pars.ElementAt(i) ,pars.ElementAt(j) ) )
					{
						return false;
					}
				}
			}
			return true;



			//throw new NotImplementedException();
		}

	}
}
