using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.vow_.xpn_.unacceptable_.be_
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// for inheritators, the vow of be shall be placed after the namespace segment of "be", for in this way, it illustrates the fact that "vow" is constrcuted on "b", which is different from other "vow" that may be unfounded on "be", but, for examples has its own implementation logic.
	/// </remarks>
	///
	[Obsolete(nameof(nilnul.obj.be.Vow4<T>))]

	public class General<T,TVow>
		:nilnul.obj.be.vow_.xpn_.Unacceptable<T, nilnul.obj.BeI1<T>, TVow>

		where TVow:nilnul.obj._vow_.BlankI
	{
		//private nilnul.obj.BeI1<T> _be;

		//public nilnul.obj.BeI1<T> be
		//{
		//	get { return _be; }
		//	set { _be = value; }
		//}

		public General(nilnul.obj.BeI1<T> be):base(be)
		{
		}
		public General(nilnul.obj.BeI1<T> be,string msg):base(be, msg)
		{
			
		}

		//public override void vow(T obj)
		//{
		//	nilnul.obj_.bit.vow_.true_.xpn_.OfVow<TVow>.Singleton.vow(_be.be(obj));

		//	//nilnul.obj.vow_.true_.xpn_.Unacceptable.True.Vow( _be.be(obj),$"{this._be.GetType().FullName}({obj}) not true.");
		//	//throw new NotImplementedException();
		//}
	}


	//public class OfVow<T,TVow, TBe> : General<T,TVow>
	//	where TBe : nilnul.obj.BeI1<T>, new()
	//	where TVow:nilnul.obj._vow_.BlankI
	//{
	//	public OfVow( ) : base(nilnul.obj_.Singleton<TBe>.Instance)
	//	{
	//	}
	//	public OfVow(string msg):base(nilnul.obj_.Singleton<TBe>.Instance,msg)
	//	{

	//	}

	//	static public OfVow<T,TVow, TBe> Singleton
	//	{
	//		get
	//		{
	//			return nilnul.obj_.Singleton<OfVow<T,TVow,TBe>>.Instance;
	//		}
	//	}
	//}
	

}