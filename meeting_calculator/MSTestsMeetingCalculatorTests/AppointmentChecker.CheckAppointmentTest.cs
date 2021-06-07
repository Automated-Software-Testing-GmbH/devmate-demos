namespace MeetingCalculatorTests
{
	using System;
	using System.Collections.Generic;
	using System.Reflection;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class CheckAppointmentTestCase
	{
		[AttributeUsage(AttributeTargets.Method)]
		private class PositiveTests : Attribute, ITestDataSource
		{
			public IEnumerable<object[]> GetData(MethodInfo methodInfo)
			{
				yield return new object[]
				{
					new ExpectedValueTestData<Boolean>
					{
						Name = @"set your test name here - set your test description here",
						ObjectUnderTest = /* TODO: Replace 'default' by your expected value */ default,
						Params = new Parameters
						{
							Meeting2check = /* TODO: Replace 'default' by your expected value */ default
						},
						ExpectedValue = /* TODO: Replace 'default' by your expected value */ default
					}
				};
			}

			public string GetDisplayName(MethodInfo methodInfo, object[] data)
			{
				return (data[0] as ExpectedValueTestData<Boolean>)?.Name;
			}
		}

		[AttributeUsage(AttributeTargets.Method)]
		private class TestsThrowingException : Attribute, ITestDataSource
		{
			public IEnumerable<object[]> GetData(MethodInfo methodInfo)
			{
				yield return new object[]
				{
					new TestThrowingExceptionData
					{
						Name = @"set your test name here - set your test description here",
						ObjectUnderTest = /* TODO: Replace 'default' by your expected value */ default,
						Params = new Parameters
						{
							Meeting2check = /* TODO: Replace 'default' by your expected value */ default
						},
						ExpectedException = /* TODO: Replace 'Exception' by your expected exception */ typeof(Exception)
					}
				};
			}

			public string GetDisplayName(MethodInfo methodInfo, object[] data)
			{
				return (data[0] as TestThrowingExceptionData)?.Name;
			}
		}

		[DataTestMethod]
		[PositiveTests]
		public void CheckAppointmentTest(ExpectedValueTestData<Boolean> data)
		{
			var actual = data.ObjectUnderTest.CheckAppointment(data.Params.Meeting2check);
			Assert.AreEqual(data.ExpectedValue, actual);
		}

		[DataTestMethod]
		[TestsThrowingException]
		public void CheckAppointmentTestThrowingException(TestThrowingExceptionData data)
		{
			try
			{
				data.ObjectUnderTest.CheckAppointment(data.Params.Meeting2check);
				Assert.Fail();
			}
			catch (Exception e)
			{
				Assert.AreEqual(e.GetType(), data.ExpectedException);
			}
		}

		public class ExpectedValueTestData<TExpected>
		{
			public string Name;
			public MeetingCalculator.AppointmentChecker ObjectUnderTest;
			public Parameters Params;
			public TExpected ExpectedValue;
		}

		public class TestThrowingExceptionData
		{
			public string Name;
			public MeetingCalculator.AppointmentChecker ObjectUnderTest;
			public Parameters Params;
			public Type ExpectedException;
		}

		public class Parameters
		{
			public MeetingCalculator.MeetingAppointment Meeting2check;
		}
	}
}

/*
WARNING: Modification of this comment will make it impossible to merge user-defined changes

BEGIN_CODEGEN_DATA
H4sIAAAAAAAAAO1WS0/bQBA+G6n/YcQFG6Wm6hEobRpSxIGCwHCJOGzWE7Kt43V31wEL5b93H37EzqOVQCqHSons3Xl
9M/PNrlMyQ5kRinCBqFj6MCAJzROiuIhQKvlu5/ndjpdLLYGbQiqcHXXW4YAnCVLFeCrDM0xRMLqic42TUqcRXTAquO
QTFd4xmZPkRuUx46EJG3GeyPA2ZcqstLK20nYjsxokRMp7vcryccIoULOGwRTpz36WcZaqGabWbkAkaj2TgDfqKyXYO
Fd4K8kD+vUyIuIBlQwvUE15HBjHXibYnCgsXV9xyRSbo60HHEJt2oNzs3dKFLnhuaAmmItWYTsfpvkMBRkneMzHP3QF
RvcncIbWxnchz9MJh1n9Glh758UrGCYxCFS5SCHFR6icOHGp5RnJ8CnTEozvSJJjBev4qy4kkvSkVKwMvO+67fAJvux
KVFBo8KC0CaRme4oC4T20JTFKKlhmOmgVdnuVq0sL6TaN0TJGez3Yh+jy9PIQrjFLDLX2YpyQPFF7MC6cTyzRwtzAhf
0DKFVqt1dEkJnU3kxydoEKhazEdSZeyduP1DDghdErp4saRqusr+N94Z6LI/tcWGbXjJGaW3o2DEWY1BEK06n1TOnVb
IBY97pFnJIyvhGMPtwDkX8gSPA5NJFqTDWwFwyOHZhoKvijTmn4RNHR561OkD14umhNmP/D88LhaXq/LkItXRMDa0sd
RxUZ8olf6wf/dqA28mXzLBmpMXPhLQdHrevFTZFDPucsXnuv+dtHuQHvsM+JAEKVvmF1+Y0s7LAu7AaxWYaORGGLIoF
Lqi8lChX2BQ5/ab9Ov4WqV4Z0BtvyX39K/FUhVqz8jT3pFkWJYrm9r1OWqi7fCEv8YKn/HiWKTqGhLmCLXd16ov6QUp
Gmux/0oFXchvyr9Gp9EK3nSFRtn6yctOWgNMwt91e+C8OlktgSoYBO6VoOmvPHvcqWtEbURny0Ka+tp/SbSEi3DVbat
TGf9un8vB1oubOEF1o8rKKYv/79BrkThtXdCwAA
END_CODEGEN_DATA
*/
