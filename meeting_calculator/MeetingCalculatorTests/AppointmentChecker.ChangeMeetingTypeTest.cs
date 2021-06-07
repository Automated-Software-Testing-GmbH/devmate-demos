﻿/*
* DO NOT MODIFY THIS COMMENT
* Generated by devmate
* Test model: d486f12a-7c0a-4fcd-8085-61e34a68ab31
*/
using System;
using System.Collections.Generic;
using NUnit.Framework;


namespace MeetingCalculatorTests
{


	public class ChangeMeetingTypeTestCase
	{
		private static IEnumerable<TestCaseData> PositiveTests()
		{
			yield return new TestCaseData(new MeetingCalculator.AppointmentChecker(new List<MeetingCalculator.MeetingAppointment> {new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 8, 0, 0), new DateTime(2020, 9, 18, 9, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 9, 0, 0), new DateTime(2020, 9, 18, 10, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 10, 0, 0), new DateTime(2020, 9, 18, 11, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 18, 12, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 14, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 20, 0, 0), new DateTime(2020, 9, 18, 21, 0, 0))}), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 12, 30, 0), new DateTime(2020, 9, 18, 13, 0, 0)), MeetingCalculator.MeetingAppointment.MeetingType.privateMeeting, new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 12, 30, 0), new DateTime(2020, 9, 18, 13, 0, 0), null, MeetingCalculator.MeetingAppointment.MeetingType.privateMeeting))
				.SetName("SetPrivate")
				.SetDescription("");
			yield return new TestCaseData(new MeetingCalculator.AppointmentChecker(new List<MeetingCalculator.MeetingAppointment> {new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 8, 0, 0), new DateTime(2020, 9, 18, 9, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 9, 0, 0), new DateTime(2020, 9, 18, 10, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 10, 0, 0), new DateTime(2020, 9, 18, 11, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 11, 0, 0), new DateTime(2020, 9, 18, 12, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 14, 0, 0))}), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 12, 30, 0), new DateTime(2020, 9, 18, 13, 0, 0)), MeetingCalculator.MeetingAppointment.MeetingType.jobMeeting, new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 12, 30, 0), new DateTime(2020, 9, 18, 13, 0, 0), null, MeetingCalculator.MeetingAppointment.MeetingType.jobMeeting))
				.SetName("SetJob")
				.SetDescription("");
			yield return new TestCaseData(new MeetingCalculator.AppointmentChecker(new List<MeetingCalculator.MeetingAppointment> {new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 8, 0, 0), new DateTime(2020, 9, 18, 9, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 9, 0, 0), new DateTime(2020, 9, 18, 10, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 10, 0, 0), new DateTime(2020, 9, 18, 11, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 18, 12, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 14, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 20, 0, 0), new DateTime(2020, 9, 18, 21, 0, 0))}), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 12, 30, 0), new DateTime(2020, 9, 18, 13, 0, 0)), MeetingCalculator.MeetingAppointment.MeetingType.videoCall, new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 12, 30, 0), new DateTime(2020, 9, 18, 13, 0, 0), null, MeetingCalculator.MeetingAppointment.MeetingType.videoCall))
				.SetName("SetVideoCall")
				.SetDescription("");
		}

		private static IEnumerable<TestCaseData> TestsThrowingException()
		{
			yield return new TestCaseData(new MeetingCalculator.AppointmentChecker(new List<MeetingCalculator.MeetingAppointment> {new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 8, 0, 0), new DateTime(2020, 9, 18, 9, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 9, 0, 0), new DateTime(2020, 9, 18, 10, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 10, 0, 0), new DateTime(2020, 9, 18, 11, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 18, 12, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 14, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 20, 0, 0), new DateTime(2020, 9, 18, 21, 0, 0))}), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 13, 0, 0)), MeetingCalculator.MeetingAppointment.MeetingType.videoCall, typeof(Exception))
				.SetName("ExceptionEvent")
				.SetDescription("meeting2Change: invalidAppointmentTime");
			yield return new TestCaseData(new MeetingCalculator.AppointmentChecker(new List<MeetingCalculator.MeetingAppointment> {new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 8, 0, 0), new DateTime(2020, 9, 18, 9, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 9, 0, 0), new DateTime(2020, 9, 18, 10, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 10, 0, 0), new DateTime(2020, 9, 18, 11, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 11, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 9, 18, 12, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 0, 0), new DateTime(2020, 9, 18, 14, 0, 0)), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 20, 0, 0), new DateTime(2020, 9, 18, 21, 0, 0))}), new MeetingCalculator.MeetingAppointment(new DateTime(2020, 9, 18, 13, 30, 0), new DateTime(2020, 9, 18, 13, 0, 0)), MeetingCalculator.MeetingAppointment.MeetingType.videoCall, typeof(Exception))
				.SetName("ExceptionBackwards")
				.SetDescription("meeting2Change: invalidAppointmentEndStart");
		}

		[Test]
		[TestCaseSource("PositiveTests")]
		public void ChangeMeetingTypeTest(MeetingCalculator.AppointmentChecker instance, MeetingCalculator.MeetingAppointment meeting2Change, MeetingCalculator.MeetingAppointment.MeetingType typeOfMeeting, MeetingCalculator.MeetingAppointment expected)
		{
			MeetingCalculator.MeetingAppointment actual = instance.ChangeMeetingType(meeting2Change, typeOfMeeting);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		[TestCaseSource("TestsThrowingException")]
		public void ChangeMeetingTypeTestThrowingException(MeetingCalculator.AppointmentChecker instance, MeetingCalculator.MeetingAppointment meeting2Change, MeetingCalculator.MeetingAppointment.MeetingType typeOfMeeting, Type expected)
		{
			Assert.Throws(expected, () => instance.ChangeMeetingType(meeting2Change, typeOfMeeting));
		}
	}
}

/*
WARNING: Modification of this comment will make it impossible to merge user-defined changes

BEGIN_CODEGEN_DATA
H4sIAAAAAAAAAO2ZbW/aMBDHXweJ72DxKlSQ8rSOPkod0K3bgEqkk6ZpL4xztF4TJ7OdUFT1u88JaYBC23SgrUiRgpT
Y5/vfnZUfl2R3J5/bQe0+6vVN1O23z8++I/PT+QC1+t1up2eGsx+BAccSLDScIAsCR52H4yYIiRzXAvsAWY3m3qhaw+
X3pILLjRGxys1K8115rwr1Bt5r4mG9qtbs5nP5HMMOCA8TQF0ASdlVC9vEt7F0eehS5HN3+ZzmCzWDBhMhwTl8dG20X
NsGIqnLhBGFR8nMpnfJqDTOuJIZu/zmMNTUPH9oU4KIjYVArWvMriBWNycehLotLFRaWqiteZwGKkskJJZq1XmH+Y6q
wdCGowfTNpb4BF24gkoaRA6EXgzXRg60CQXbQhykzxliMEbz6/RwYCl549TzXMqkA0y2roHcAI8Mv1Ihj5at45G5RSf
obrXjZdPIsQoFTOqAXqvUKiW0X0LVZgmpQ11UiiX0tM1+bBMbram4n0KxWtmoZOLuWc3qZjVjd6Vk/gtllnHJhAeEji
hYz0dT22w09TQVaGxUs5am6rWk6vcbylQVrv5yqvVZqmkEjTl8GDEv4qH/EbUy8m177dCLEcI0zRiA7CmA6gV1cjE1K
czNtUEQTr2QwHqhUDzMmJcx71l3b5ds20OZX+5wGwkzC3slXT67w4wsGVmybirrpmJgBNQCV5nbW4W5JOqVlPv2MPsS
6+6jx9X0T6DRk6d5zd2xCqRzS2DqLnsUzeCZwfPNwTNVphtip1TX7khPmLDMpWSqEyg/T5LJmfqvTV+bHSDKAmxTay6
EMImsV8twk+HmzeHm3/Vqr+DNB0xuxphbYg3mdJg1kJjLxb7pR0ibn8lZyJ2B63Oi1Bfe1ReKkVH8WSBwqbX6q4CeBl
YqOtWnMQLpCogWk3t91aNS90fJy4BUonCrbjapbrVZZ5hqHSbSxzY6TpI0lgqlP05oIb74f+FUCODSOOXQ+a0c6g/xl
GKFtNu4uuFNu5/LnfI2bHA0tmID45pGSYm5iupFdHzy9xuWbEX4U8cf7CT0VyYcAAA=
END_CODEGEN_DATA
*/