using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_.binary.cumulator_.opDefault_.heritGeneric
{

	
	public class ElDefault<T, TOp>
		:
		HeritGeneric<T, TOp>
		where TOp : nilnul.obj.of_.BinaryI<T>, new()
		where T : new()
	{

		public ElDefault() : base(nilnul._obj.typ_._UnisonX<T>.Unison)
		{

		}


		static public ElDefault<T, TOp> Unison
		{
			get
			{
				return nilnul._obj.typ_._UnisonX<ElDefault<T, TOp>>.Unison;
			}
		}


	}

	




}
