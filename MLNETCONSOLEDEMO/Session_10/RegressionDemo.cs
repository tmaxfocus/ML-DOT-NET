using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;

namespace MLNETCONSOLEDEMO.Session_10
{
	public class RegressionDemo
	{
		public static void Execute(float yearsOfExperience)
		{
			MLContext context = new MLContext();
			//Load the data
			IDataView trainingdata = context.Data.LoadFromEnumerable(data());

			//prepare data using Estimator and specify features forour input. Years of experience is the feature
			var estimator = context.Transforms.Concatenate("Features", new[] { "YearsOfExperience" });

			// prepare the pipeline and perform the regression tasks
			var pipeline = estimator.Append(context.Regression.Trainers.Sdca(labelColumnName: "Salary", maximumNumberOfIterations: 100));

			//create model
			var model = pipeline.Fit(trainingdata);

			//create prediction engine
			var pridictionEngine = context.Model.CreatePredictionEngine<InputModel, ResultModel>(model);

			var experience = new InputModel { YearsOfExperience = yearsOfExperience };

			var result = pridictionEngine.Predict(experience);
			Console.WriteLine($"Approx Salary for {experience.YearsOfExperience} Years of experience will be : {result.Salary}");
		}


		private static List<InputModel> data()
		{
			return new List<InputModel> {
			 new InputModel(1,39000),
			 new InputModel(1.3F,46200),
			 new InputModel(1.5F,37700),
			 new InputModel(2,43500),
			 new InputModel(2.2F,40000),
			 new InputModel(2.9F,5600),
			 new InputModel(3,60000),
			 new InputModel(3.2F,54000),
			 new InputModel(3.3F,64000),
			 new InputModel(3.7F,57000),
			 new InputModel(3.9f,63000),
			 new InputModel(4,55000),
			 new InputModel(4,58000),
			 new InputModel(4.1F,57000),
			 new InputModel(4.5F,61000),
			 new InputModel(4.9F,68000),
			 new InputModel(5.3F,83000),
			 new InputModel(5.9F,82000),
			 new InputModel(6,94000),
			 new InputModel(6.8F,91000),
			 new InputModel(7.1F,98000),
			 new InputModel(7.9F,10100),
			 new InputModel(8.2F,114000),
			 new InputModel(8.9F,109000),
			 new InputModel(10,109900),
			 new InputModel(10.5F,11000),
			 new InputModel(11.0F,120000),

			 new InputModel(11.6F,143000),
			 new InputModel(12.0F,150000),


			};
	}	}
}
