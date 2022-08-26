using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_
{
	
		/// <summary>
		/// >=3 or >2.
		/// multi, many, a lot, numerous. Poly is chosen 'cuz it shares something with positive >0, plural>1
		/// </summary>
		/// alias:
		///		poly means 3 or more
		///		polyn means 0 or more, where trailing 'n' means nil or natural
		public class Poly<T> : BeI3<T>
		{
			

			public bool be(IEnumerable<T> obj)
			{
				return obj.Count() > 2;
			}


			static public Poly<T> Singleton
			{
				get
				{
					return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Poly<T>>.Instance;
				}
			}


		}
	}
