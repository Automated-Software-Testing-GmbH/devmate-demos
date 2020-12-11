﻿/*
* DO NOT MODIFY THIS COMMENT
* Generated by devmate
* Test model: d7f4223f-fc6d-4a3b-9e1c-59c5de26af9a
*/

namespace MeetingCalculatorTests
{
	using System;
	using System.Collections.Generic;
	using NUnit.Framework;

	public class CheckAppointmentTestCase
	{
		private static MeetingCalculator.AppointmentChecker MyCalendarFactroy()
		{
			return new MeetingCalculator.AppointmentChecker(
				new List<MeetingCalculator.MeetingAppointment>
				{
					new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 30, 8, 0, 0), new DateTime(2020, 9,  30, 9, 0, 0)),
					new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 30, 9, 0, 0), new DateTime(2020, 9,  30, 10, 0, 0)),
					new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 30, 10, 0, 0), new DateTime(2020, 9, 30, 11, 0, 0)),
					new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 30, 11, 0, 0), new DateTime(2020, 9, 30, 12, 0, 0)),
					new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 30, 13, 0, 0), new DateTime(2020, 9, 30, 14, 0, 0)),
					new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 30, 14, 0, 0), new DateTime(2020, 9, 30, 15, 0, 0))
					});
		}

		private static IEnumerable<TestCaseData> PositiveTests()
		{
			yield return new TestCaseData(new MeetingCalculator.AppointmentChecker(new List<MeetingCalculator.MeetingAppointment> {new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 8, 0, 0), new DateTime(2020, 9, 18, 9, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 9, 0, 0), new DateTime(2020, 9, 18, 10, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 10, 0, 0), new DateTime(2020, 9, 18, 11, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 18, 12, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 14, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 20, 0, 0), new DateTime(2020, 9, 18, 21, 0, 0))}), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 12, 30, 0), new DateTime(2020, 9, 18, 13, 0, 0)), true)
				.SetName("p1")
				.SetDescription("//LinkToJira //link to AzureDevopsRequirements");
			yield return new TestCaseData(new MeetingCalculator.AppointmentChecker(new List<MeetingCalculator.MeetingAppointment> {new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 8, 0, 0), new DateTime(2020, 9, 18, 9, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 9, 0, 0), new DateTime(2020, 9, 18, 10, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 10, 0, 0), new DateTime(2020, 9, 18, 11, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 18, 12, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 14, 0, 0))}), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 12, 30, 0), new DateTime(2020, 9, 18, 13, 0, 0)), true)
				.SetName("p2")
				.SetDescription("");
			yield return new TestCaseData(new MeetingCalculator.AppointmentChecker(new List<MeetingCalculator.MeetingAppointment> {new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 8, 0, 0), new DateTime(2020, 9, 18, 9, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 9, 0, 0), new DateTime(2020, 9, 18, 10, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 10, 0, 0), new DateTime(2020, 9, 18, 11, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 18, 12, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 14, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 20, 0, 0), new DateTime(2020, 9, 18, 21, 0, 0))}), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 13, 30, 0)), false)
				.SetName("p3")
				.SetDescription("");
			yield return new TestCaseData(MyCalendarFactroy(), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 13, 30, 0)), true)
				.SetName("1")
				.SetDescription("");
		}

		private static IEnumerable<TestCaseData> TestsThrowingException()
		{
			yield return new TestCaseData(new MeetingCalculator.AppointmentChecker(new List<MeetingCalculator.MeetingAppointment> {new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 8, 0, 0), new DateTime(2020, 9, 18, 8, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 9, 0, 0), new DateTime(2020, 9, 18, 9, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 10, 0, 0), new DateTime(2020, 9, 18, 11, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 18, 12, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 14, 0, 0))}), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 12, 30, 0), new DateTime(2020, 9, 18, 13, 0, 0)), typeof(Exception))
				.SetName("n1")
				.SetDescription("instance: invalidCalendarZeroTime");
			yield return new TestCaseData(new MeetingCalculator.AppointmentChecker(new List<MeetingCalculator.MeetingAppointment> {new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 8, 0, 0), new DateTime(2020, 9, 18, 9, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 9, 0, 0), new DateTime(2020, 9, 18, 10, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 10, 0, 0), new DateTime(2020, 9, 18, 11, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 18, 12, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 14, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 20, 0, 0), new DateTime(2020, 9, 18, 21, 0, 0))}), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 13, 0, 0)), typeof(Exception))
				.SetName("n2")
				.SetDescription("Meeting2check: invalidAppointmentTime");
			yield return new TestCaseData(new MeetingCalculator.AppointmentChecker(new List<MeetingCalculator.MeetingAppointment> {new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 8, 0, 0), new DateTime(2020, 9, 18, 9, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 9, 0, 0), new DateTime(2020, 9, 18, 10, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 10, 0, 0), new DateTime(2020, 9, 18, 11, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 18, 12, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 14, 0, 0))}), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 30, 0), new DateTime(2020, 9, 18, 13, 0, 0)), typeof(Exception))
				.SetName("n3")
				.SetDescription("Meeting2check: invalidAppointmentEndStart");
		}

		[Test]
		[TestCaseSource("PositiveTests")]
		public void CheckAppointmentTest(MeetingCalculator.AppointmentChecker instance, MeetingCalculator.MeetingAppointment Meeting2check, Boolean expected)
		{
			Boolean actual = instance.CheckAppointment(Meeting2check);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		[TestCaseSource("TestsThrowingException")]
		public void CheckAppointmentTestThrowingException(MeetingCalculator.AppointmentChecker instance, MeetingCalculator.MeetingAppointment Meeting2check, Type expected)
		{
			Assert.Throws(expected, () => instance.CheckAppointment(Meeting2check));
		}
	}
}

/*
WARNING: Modification of this comment will make it impossible to merge user-defined changes

BEGIN_CODEGEN_DATA
H4sIAAAAAAAAAO1ZUW/aMBB+Bon/cOIpTBRKaLvSrpU6oBvbgGlkD9u0B9c5NqvBTm2HjlX777PTQGmBLltRt7WRQEr
s8313R74vPlx9Usg/gVYfen0Puv1W5/gDeC87A2j2u912z7OzL5CjJBp9OJmAj+ORubbjHioNI+FjsAf+0+GW69aHG0
O6429skfrJRgNrdGO7Qbd9dHfIsEHMmmohX8hzMkIVEorQRdSMf2mSgEYB0UJal6qQvyjkc5EyMzCYKI2j/Rv3laYIA
qSaCa4qcXiMXtn03nOmK8fSwJwLebpvMXNhdBIwCjQgSkHzK9LTozAUjOsRcm1hm0SZrHIWOhdKNjZJgtJEm0ULYVbm
1sa+UEJ3YuaR+0QeE6qlmDgl6yr2l6tWweubKrNRGKBdBUNjJOQkntVfpTgHjufT9HpCd6aW6Le/UQxtrk7JJpn7ESd
0M8hOm0cj8zudBPhsmk+LaHIIb4Vimo0xLu58VBOGgQ8SdSR5DD+/zrEDaTKPDd8wpZ8tWicjc4sO4WK540XT2LEJBT
02QsfddDfL0ChDbbcM5mNuNktlWG3TSGwSozsiNlIg1jbXCjlzdytmbb2YibvybP41437lPVchUjZk6N8ejbveaOppK
rC1Vkw3TdXdWdV/rClTU7j6r1OtX6WqZYQxl3O5ygB1z6idUwxrxbmxFioq2aV0FKvVN4yfeuIVkwSq1cDcgBZw9D2S
2MKxCNU7PIuYjEVHFS+lJpOITCIelET8Y3R1V9I1I2BGwIdIwP/5HZ0q0/pUGYzZkARqCevrd2T9klbjLyW4VNVW70G
Kf9bAxI2LZ5skk8pcN/RYOpnde1fJ9epyJpL/zS5lEqIYOjOOlRbIzVezm3HDZE5xDxgfk4D5U5X6iFJY3GxPk+1pHi
JdH8Oe5jcUYnVTk4TmUsvgmUzM/xGbqUSmEg9UJdbI2LW/1Fd3JL+kbJv7A02kvr63/2TJ+nl2ZWk7EJGkBuzacUSxF
BslpzNjwfylhzNOqiOY6QaknKrGcC21MjwXIkDCAb+Zh0mbR+mqvZhOmW4rIgEczJAqN4N1rjlNlOxIKZS6ciSxfWbW
O1OEcuIwbeWW90EpS7jYP91DTT3z6C0raFKROCY1Vw+nBAeHqas7q5v9ms9PTyqrk80cAAA=
END_CODEGEN_DATA
*/
