﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op.unary
{
	public partial class Identity<T>

	{

		static private readonly Identity<T> _Instance = new Identity<T>();
		static public Identity<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		public Identity()
		{
		}

		public T eval(T x) {

			return x;
		
		}
				

		static public T Eval(T x) {

			return x;
		
		}


	

		

	}
}
