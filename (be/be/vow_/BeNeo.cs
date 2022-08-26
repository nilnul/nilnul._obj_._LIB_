using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be.vow_
{


	/// <summary>
	/// vow of ref.
	/// on reference of Be.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TBe"></typeparam>
	public class BeNeo<T, TBe> :

		nilnul.obj.be.VowOfRef<T>

		where TBe : nilnul.obj.BeOfRefI<T>,new()

	{
		

		public BeNeo() : base(
			 
				 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
			)
		{
		}



		static public BeNeo<T, TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeNeo<T, TBe>>.Instance;
			}
		}



	}

	





}