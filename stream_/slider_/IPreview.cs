using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider_
{
	/// <summary>
	/// move ahead one by one. but each time we know multiple elements from the future;
	/// 
	/// </summary>
	/// <remarks>
	///we prefer thsi to <see cref="stream_.IScroll"/> as the current is in line with <see cref="ISlider"/>
	/// 
	/// </remarks>
	/// vs:
	///		<see cref="stream_.IPrefetch"/> which might peek of 0 terms, or 1 term, whileas this at least peek 1 term as <see cref="ISlider"/>.current, and then preview another n=0,1,2... terms;
	/// alias:
	///		window
	///		peek
	///		lookahead
	///		buffered
	///		
	public interface IPreview:ISlider {

	}

	//[Obso`]
	//public interface IScroll
	//{
	//}



}
