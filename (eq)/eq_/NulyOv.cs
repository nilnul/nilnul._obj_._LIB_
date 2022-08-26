using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.eq_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T">nulable. default to class? </typeparam>
	public interface  OvNulyI<T>
		:EqI<T>
	{
	}

	public class OvNuly<T>
		:
		nilnul.obj.Box1<IEqualityComparer<T>>
		,
		OvNulyI<T>

	{
		public OvNuly(IEqualityComparer<T> val) : base(val)
		{
		}

		public bool Equals(T x, T y)
		{
			if (x is null)
			{
				if (y is null)
				{
					return true;
				}
				return false;
			}
			if (y is null)
			{
				return false;
			}
			return boxed.Equals(x, y);
			//throw new NotImplementedException();
		}

		public int GetHashCode(T obj)
		{
			if (obj is null)
			{
				return 0;
			}
			return boxed.GetHashCode(obj);
			//throw new NotImplementedException();
		}
	}

	public interface NulyOvStructI<T>
		:OvNulyI<T?>
		where T: struct
	{ }

	public class NulyOvStruct<T>
		:
		nilnul.obj.Box1<IEqualityComparer<T> >
		,
		OvNulyI<T?>
		where T:struct

	{
		public NulyOvStruct(IEqualityComparer<T> val) : base(val)
		{
		}

		public bool Equals(T? x, T? y)
		{
			if (x is null)
			{
				if (y is null)
				{
					return true;
				}
				return false;
			}
			if (y is null)
			{
				return false;
			}
			return boxed.Equals(x.Value, y.Value);
			//throw new NotImplementedException();
		}

		public int GetHashCode(T? obj)
		{
			if (obj is null)
			{
				return 0;
			}
			return boxed.GetHashCode(obj.Value);
			//throw new NotImplementedException();
		}
	}

}
