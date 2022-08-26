﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.converse.cumulator_.opDefault_
{

	
	public class ElDefault<T, TOp>
		:
		OpDefault<T, TOp>
		where TOp : nilnul.obj.op_.BinaryI<T>, new()
		where T : new()
	{

		public ElDefault() : base(nilnul.obj_.Singleton<T>.Instance)
		{

		}

		static public ElDefault<T, TOp> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<ElDefault<T, TOp>>.Instance;
			}
		}


	}

	




}