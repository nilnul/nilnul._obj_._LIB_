using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._vow;

namespace nilnul.obj.vow_.xpN_
{
	

	/// <summary>
	/// let subtype inherit this and the exception is bound to the xpn typePar
	/// </summary>
	/// <typeparam name="T">the obj to be vowed</typeparam>
	/// <typeparam name="THeirVow">subtype who inherits this type</typeparam>
	public abstract class OfHeirA<T, THeirVow>
		: VowA1<T, _vow.FailException<THeirVow>>
		where THeirVow : _vow_.BlankI
	{
		public OfHeirA(FailException<THeirVow> xpn) : base(xpn)
		{
		}
		public OfHeirA(string s):this(new FailException<THeirVow>(s))
		{

		}
		public OfHeirA():this( new FailException<THeirVow>())
		{

		}
	}

	public abstract class OfThisA<T>
		: OfHeirA<T, OfThisA<T >>
	{
		public OfThisA(FailException<OfThisA<T>> xpn) : base(xpn)
		{
		}
		
		public OfThisA(string s):this(new FailException<OfThisA<T>>(s))
		{

		}
		public OfThisA():this( new FailException<OfThisA<T>>())
		{

		}


	}

	


}
