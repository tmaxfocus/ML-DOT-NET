using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MLNETCONSOLEDEMO.Session_10
{
	public class InputModel
	{
		public float YearsOfExperience { get; set; }

		public float Salary { get; set; }

        public InputModel()
        {
            
        }

        public InputModel(float yearsOfExperience, float salary )
        {
            YearsOfExperience = yearsOfExperience;
            Salary = salary;    
        }
    }
}
