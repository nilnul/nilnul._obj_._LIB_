using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{
	[Obsolete()]
	public interface VowI<T, TBe>
	: nilnul.obj.VowI2<T>
	{ }
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// for inheritators, the vow of be shall be placed after the namespace segment of "be", for in this way, it illustrates the fact that "vow" is constrcuted on "b", which is different from other "vow" that may be unfounded on "be", but, for examples has its own implementation logic.
	/// </remarks>
	///
	[Obsolete()]
	public class Vow3<T, TBe, TXpn>
		: nilnul.obj.VowA1<T, TXpn>
		where TBe : nilnul.obj.BeI1<T>
		where TXpn : Exception
	{
		private TBe _be;

		public TBe be
		{
			get { return _be; }
			set { _be = value; }
		}

		private nilnul.obj_.bit.vow_.True<TXpn> _true;
		public nilnul.obj_.bit.vow_.True<TXpn> true0
		{
			get { return _true; }
			set { _true = value; }
		}


		public Vow3(TBe be, TXpn xpn) : base(xpn)
		{
			_be = be;
			_true = new nilnul.obj_.bit.vow_.True<TXpn>(this.boxed);
		}
		//public Vow3(TBe be, string xpn):this(be, new TXpn() { })
		//{

		//}

		public override void vow(T obj)
		{
			_true.vow(_be.be(obj));

			//if (!_be.be(obj))
			//{
			//	this.boxed.Source=  obj.ToString();
			//	throw this.boxed;
			//}
			//throw new NotImplementedException();
		}
	}

	[Obsolete()]
	public class Vow3<T, TXpn> : Vow3<T, nilnul.obj.BeI1<T>, TXpn>
		where TXpn : Exception
	{
		public Vow3(BeI1<T> be, TXpn xpn) : base(be, xpn)
		{
		}
	}

	public class Vow3_xpnGeneral<T, TBe> : Vow3<T, TBe, Exception>
		where TBe : nilnul.obj.BeI1<T>
	{
		public Vow3_xpnGeneral(TBe be, Exception xpn) : base(be, xpn)
		{
		}
	}


	[Obsolete()]
	public class Vow3<T> : Vow3<T, Exception>
	{
		public Vow3(BeI1<T> be, Exception xpn) : base(be, xpn)
		{
		}

		public Vow3(BeI1<T> be, string xpn) : this(be, new Exception(xpn))
		{

		}
	}

}