using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul_obj.type;

namespace nilnul_obj.bit
{
	public partial class PredicateSingleton
		:nilnul_obj.type.Singleton<PredicateSingleton>

	{

		static private readonly PredicateSingleton _Instance = new PredicateSingleton();
		static public PredicateSingleton Instance
		{
			get
			{
				return _Instance;
			}
		}
		private PredicateSingleton()
		{

		}
				
		static PredicateSingleton() {
			Singleton<PredicateSingleton>._Instance = _Instance;
			
		}
	}
}
