﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.splice_
{
	/// <summary>
	/// convert a str to an element
	/// </summary>
	///
	public interface OfArrI<T>
		:ISplice
		
	{
		T splice(T[] x);
	}



}