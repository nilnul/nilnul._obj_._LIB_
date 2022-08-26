using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	
		/// <summary>
		/// >=2 or >1.
		/// </summary>
		public class Plural<T> : BeI3<T>
		{
			

			public bool be(IEnumerable<T> obj)
			{
				return obj.Count() >= 2;
			}


			static public Plural<T> Singleton
			{
				get
				{
					return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Plural<T>>.Instance;
				}
			}


		}
	}
