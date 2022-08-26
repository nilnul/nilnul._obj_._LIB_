using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.vow.ee_
{


	/// <summary>
	/// 
	/// </summary>
	/// <remarks>
	/// vowDefault uses the default singleton
	/// vowNeo creates a new one everytime.
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TVow"></typeparam>
	public class Defaultable<T, TVow>
		:
		vow.Ee1<T,TVow>
		
		where TVow : nilnul.obj.VowI2<T>,new()
	{
		public Defaultable(T val) : base( val, nilnul.obj_.singleton_.Lazy<TVow>.Instance)
		{
		}


		
	}


}
