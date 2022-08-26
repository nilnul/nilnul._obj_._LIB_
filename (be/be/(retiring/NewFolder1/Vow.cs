using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// for inheritators, the vow of be shall be placed after the namespace segment of "be", for in this way, it illustrates the fact that "vow" is constrcuted on "b", which is different from other "vow" that may be unfounded on "be", but, for examples has its own implementation logic.
	/// </remarks>
	///
	[Obsolete()]
	public class Vow2<T>
		: 
		
		nilnul.obj.VowI<T>
	{
		private nilnul.obj.BeI1<T> _be;
		public nilnul.obj.BeI1<T> be
		{
			get { return _be; }
			set { _be = value; }
		}

		public Vow2(nilnul.obj.BeI1<T> be)
		{
			_be = be;
		}

		public void vow(T obj)
		{
			nilnul.obj.vow_.True.Vow( _be.be(obj),$"{this._be.GetType().FullName}({obj}) not true.");
			//throw new NotImplementedException();
		}
	}

	[Obsolete()]
	public class Vow2<T,TBe> : Vow2<T>
		where TBe : nilnul.obj.BeI1<T>, new()
	{
		public Vow2( ) : base(nilnul.obj_.Singleton<TBe>.Instance)
		{
		}

		static public Vow2<T,TBe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Vow2<T,TBe>>.Instance;
			}
		}
	}
	

}