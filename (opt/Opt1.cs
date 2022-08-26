using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._opt;

namespace nilnul.obj
{
	public interface IOpt {}
	/// <summary>
	/// alias:Maybe{T}
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IOpt<T>:IOpt { }

	/// <summary>
	///
	/// </summary>
	public interface OptI1 {
	}

	public interface OptI<T> : OptI1 {

	}
	public class Opt1<T>:OptI<T>
	{
		private OptI<T> _val;

		public OptI<T> val
		{
			get { return _val; }
			set { _val = value; }
		}

		

		public Opt1()
		{
			_val = new opt_.Non<T>();
		}

		public Opt1(T val)
		{
			_val = new opt_.One<T>(val);
		}

		public override string ToString()
		{
			return _val.ToString();
		}

		static public Opt1<T> CreateFroStr(IEnumerable<T> objs) {
			if (objs.Any())
			{
				return new Opt1<T>(objs.First());
			}
			return new Opt1<T>();
		}
	}
}
