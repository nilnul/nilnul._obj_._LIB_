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
	public class Vow<T>
		:nilnul.obj.VowI<T>
	{
		private BeI<T> _be;

		public BeI<T> be
		{
			get { return _be; }
			set { _be = value; }
		}


		public Vow(nilnul.obj.BeI<T> be)
		{
			_be = be;
		}

		public void vow(T obj)
		{

			nilnul.obj.vow_.True.Vow( _be.be(obj));
			//throw new NotImplementedException();
		}
	}

	[Obsolete()]
	public class Vow<T,TBe> : Vow<T>
		where TBe : BeI<T>
	{
		public Vow( TBe be) : base(be)
		{
		}
	}
	[Obsolete()]
	public class Vow1<T,TBe> : Vow<T>
		where TBe : BeI<T>, new()
	{
		public Vow1( ) : base(SingletonByDefault<TBe>.Instance)
		{
		}



		static public Vow1<T,TBe> Singleton
		{
			get
			{
				return nilnul.obj.SingletonByDefault<Vow1<T,TBe>>.Instance;
			}
		}

	}

	[Obsolete(nameof(Vow1<T,TBe>) )]
	public class Vow_beDefault<T,TBe> : Vow<T>
		where TBe : BeI<T>, new()
	{
		public Vow_beDefault( ) : base(SingletonByDefault<TBe>.Instance)
		{
		}


		static public readonly Vow_beDefault<T,TBe> Singleton = nilnul.obj.SingletonByDefault<Vow_beDefault<T,TBe>>.Instance;

	}


}
