using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace MLNETCONSOLEDEMO.Session_10
{
	public class ResultModel
	{
		[ColumnName("Score")]
		public float Salary { get; set; }
	}
}
