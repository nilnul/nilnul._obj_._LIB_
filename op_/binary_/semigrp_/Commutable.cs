using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_.semigrp_
{

	public interface ICommutable : ISemigrp
		,
		binary_.ICommutable
	
		{ }
	public interface ICommutable<T> : ICommutable, ISemigrp<T> { }


	public interface CommutableI<T>
		:
		SemigrpI<T>
		,
		ICommutable<T>
		,
		binary_.CommutableI<T>
		

	{

	}

	




}
