using System;

using NUnit.Framework;

using BLToolkit.Data;

namespace Data
{
	[TestFixture]
	public class ExecuteScalarTest
	{
		[Test]
		public void RegressionTest()
		{
			using (DbManager db = new DbManager())
			{
				int expectedValue = 12345;
				int actualValue = Convert.ToInt32(db
					.SetSpCommand("Scalar_DataReader").ExecuteScalar());

				Assert.AreEqual(expectedValue, actualValue);
			}
		}

		[Test]
		public void DataReaderTest()
		{
			using (DbManager db = new DbManager())
			{
				int expectedValue = 12345;
				int actualValue = Convert.ToInt32(db
					.SetSpCommand("Scalar_DataReader")
					.ExecuteScalar(ScalarSourceType.DataReader));
				
				Assert.AreEqual(expectedValue, actualValue);
			}
		}

		[Test]
		public void DataReader2Test()
		{
			using (DbManager db = new DbManager())
			{
				string expectedValue = "54321";
				string actualValue = Convert.ToString(db
					.SetSpCommand("Scalar_DataReader")
					.ExecuteScalar(ScalarSourceType.DataReader, 1));

				Assert.AreEqual(expectedValue, actualValue);
			}
		}

		[Test]
		public void DataReader3Test()
		{
			using (DbManager db = new DbManager())
			{
				string expectedValue = "54321";
				string actualValue = Convert.ToString(db
					.SetSpCommand("Scalar_DataReader")
					.ExecuteScalar(ScalarSourceType.DataReader, "stringField"));

				Assert.AreEqual(expectedValue, actualValue);
			}
		}
		
		[Test]
		public void OutputParameterTest()
		{
			using (DbManager db = new DbManager())
			{
				int expectedValue = 12345;
				int actualValue = Convert.ToInt32(db
					.SetSpCommand("Scalar_OutputParameter")
					.ExecuteScalar(ScalarSourceType.OutputParameter));

				Assert.AreEqual(expectedValue, actualValue);
			}
		}

		[Test]
		public void OutputParameter2Test()
		{
			using (DbManager db = new DbManager())
			{
				string expectedValue = "54321";
				string actualValue = Convert.ToString(db
					.SetSpCommand("Scalar_OutputParameter")
					.ExecuteScalar(ScalarSourceType.OutputParameter, 1));

				Assert.AreEqual(expectedValue, actualValue);
			}
		}

		[Test]
		public void OutputParameter3Test()
		{
			using (DbManager db = new DbManager())
			{
				string expectedValue = "54321";
				string actualValue = Convert.ToString(db
					.SetSpCommand("Scalar_OutputParameter")
					.ExecuteScalar(ScalarSourceType.OutputParameter, "outputString"));

				Assert.AreEqual(expectedValue, actualValue);
			}
		}
		
		[Test]
		public void ReturnParameterTest()
		{
			using (DbManager db = new DbManager())
			{
				int expectedValue = 12345;
				int actualValue = Convert.ToInt32(db
					.SetSpCommand("Scalar_ReturnParameter")
					.ExecuteScalar(ScalarSourceType.ReturnValue));

				Assert.AreEqual(expectedValue, actualValue);
			}
		}

		[Test]
		public void AffectedRowsTest()
		{
			using (DbManager db = new DbManager())
			{
				int expectedValue = -1;
				int actualValue = Convert.ToInt32(db
					.SetSpCommand("Scalar_ReturnParameter")
					.ExecuteScalar(ScalarSourceType.AffectedRows));

				Assert.AreEqual(expectedValue, actualValue);
			}
		}

#if FW2
		[Test]
		public void FW2RegressionTest()
		{
			using (DbManager db = new DbManager())
			{
				int expectedValue = 12345;
				int actualValue = db
					.SetSpCommand("Scalar_DataReader").ExecuteScalar<int>();

				Assert.AreEqual(expectedValue, actualValue);
			}
		}

		[Test]
		public void FW2DataReaderTest()
		{
			using (DbManager db = new DbManager())
			{
				int expectedValue = 12345;
				int actualValue = db
					.SetSpCommand("Scalar_DataReader")
					.ExecuteScalar<int>(ScalarSourceType.DataReader);

				Assert.AreEqual(expectedValue, actualValue);
			}
		}

		[Test]
		public void FW2DataReader2Test()
		{
			using (DbManager db = new DbManager())
			{
				string expectedValue = "54321";
				string actualValue = db
					.SetSpCommand("Scalar_DataReader")
					.ExecuteScalar<string>(ScalarSourceType.DataReader, 1);

				Assert.AreEqual(expectedValue, actualValue);
			}
		}
#endif
	}
}