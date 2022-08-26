using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary_
{

	public interface ISemigrp : magma_.IAssociative
	
		{ }
	public interface ISemigrp<T> : ISemigrp, magma_.IAssociative<T> { }


	public interface SemigrpI<T> : magma_.AssociativeI<T>
		,ISemigrp<T>
		

	{

	}

	




}
