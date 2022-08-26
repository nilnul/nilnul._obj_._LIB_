using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.slider._series_
{
	public interface SeriesI<T>
		:MoveNextI
		,CurrentI<T>
		,NextAccumulantI<T>
	{
	}
}
