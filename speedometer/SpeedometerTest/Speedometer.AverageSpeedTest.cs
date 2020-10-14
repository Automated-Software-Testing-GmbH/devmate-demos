﻿/*
* DO NOT MODIFY THIS COMMENT
* Generated by devmate
* Test model: a8d26c27-a654-4d6d-857e-3e53b2919d0b
*/

namespace AvgSpeed.Tests
{
	using System;
	using System.Collections.Generic;
    using Moq;
	using NUnit.Framework;

	public class AverageSpeedTestCase
	{
		private static AvgSpeed.ISpeedSensor CreateSensorStub()
		{
			return new Mock<AvgSpeed.ISpeedSensor>().Object;
		}

		private static AvgSpeed.Preferences CreatePreferences(UnitsNet.Units.SpeedUnit preferredSpdUnit)
		{
			return new AvgSpeed.Preferences
			{
				PreferredLengthUnit = UnitsNet.Units.LengthUnit.KilolightYear,
				PreferredSpeedUnit = UnitsNet.Units.SpeedUnit.KilometerPerHour
			};
		}

		private static AvgSpeed.ITrack CreateTrackStub(System.Int32 value, UnitsNet.Units.LengthUnit unit)
		{
			var trackMock = new Mock<AvgSpeed.ITrack>();
			trackMock.Setup(track => track.Distance).Returns(new UnitsNet.Length(value, unit));
			return trackMock.Object;
		}

		private static IEnumerable<TestCaseData> PositiveTests()
		{
			yield return new TestCaseData(new AvgSpeed.Speedometer(CreateSensorStub(), CreatePreferences(UnitsNet.Units.SpeedUnit.KilometerPerHour)), new UnitsNet.Duration(2, UnitsNet.Units.DurationUnit.Hour), CreateTrackStub(60, UnitsNet.Units.LengthUnit.Kilometer), new UnitsNet.Speed(30, UnitsNet.Units.SpeedUnit.KilometerPerHour))
				.SetName("p1")
				.SetDescription("");
		}

		private static IEnumerable<TestCaseData> TestsThrowingException()
		{
			yield return new TestCaseData(new AvgSpeed.Speedometer(CreateSensorStub(), CreatePreferences(UnitsNet.Units.SpeedUnit.KilometerPerHour)), new UnitsNet.Duration(), CreateTrackStub(60, UnitsNet.Units.LengthUnit.Kilometer), typeof(ArgumentException))
				.SetName("n1")
				.SetDescription("duration: zero");
			yield return new TestCaseData(new AvgSpeed.Speedometer(CreateSensorStub(), CreatePreferences(UnitsNet.Units.SpeedUnit.KilometerPerHour)), new UnitsNet.Duration(-1, UnitsNet.Units.DurationUnit.Minute), CreateTrackStub(60, UnitsNet.Units.LengthUnit.Kilometer), typeof(ArgumentException))
				.SetName("n2")
				.SetDescription("duration: negative");
			yield return new TestCaseData(new AvgSpeed.Speedometer(CreateSensorStub(), CreatePreferences(UnitsNet.Units.SpeedUnit.KilometerPerHour)), new UnitsNet.Duration(2, UnitsNet.Units.DurationUnit.Hour), CreateTrackStub(0, UnitsNet.Units.LengthUnit.Centimeter), typeof(ArgumentException))
				.SetName("n3")
				.SetDescription("track: zero");
			yield return new TestCaseData(new AvgSpeed.Speedometer(CreateSensorStub(), CreatePreferences(UnitsNet.Units.SpeedUnit.KilometerPerHour)), new UnitsNet.Duration(2, UnitsNet.Units.DurationUnit.Hour), CreateTrackStub(-10, UnitsNet.Units.LengthUnit.Foot), typeof(ArgumentException))
				.SetName("n4")
				.SetDescription("track: negative");
			yield return new TestCaseData(new AvgSpeed.Speedometer(CreateSensorStub(), CreatePreferences(UnitsNet.Units.SpeedUnit.KilometerPerHour)), new UnitsNet.Duration(2, UnitsNet.Units.DurationUnit.Hour), null, typeof(ArgumentNullException))
				.SetName("n5")
				.SetDescription("track: nullPointer");
		}

		[Test]
		[TestCaseSource("PositiveTests")]
		public void AverageSpeedTest(AvgSpeed.Speedometer instance, UnitsNet.Duration duration, AvgSpeed.ITrack track, UnitsNet.Speed expected)
		{
			UnitsNet.Speed actual = instance.AverageSpeed(duration, track);
			Assert.AreEqual(expected.KilometersPerHour, actual.KilometersPerHour, 1e-8);
		}

		[Test]
		[TestCaseSource("TestsThrowingException")]
		public void AverageSpeedTestThrowingException(AvgSpeed.Speedometer instance, UnitsNet.Duration duration, AvgSpeed.ITrack track, Type expected)
		{
			Assert.Throws(expected, () => instance.AverageSpeed(duration, track));
		}
	}
}

/*
WARNING: Modification of this comment will make it impossible to merge user-defined changes

BEGIN_CODEGEN_DATA
H4sIAAAAAAAAAN2WW2/aMBSAn0HiP1g8hQpCgUJvayXEZUUbFynZwzTtwSSn1GpiZ7ZDy6b999luoClpKWVTt07i4tg
+t++c2Ke6V8jvoe4YjcYuGo67g/5n5F4MHNQZD4e9katX3wMFjiX4aLpAPsxDNdbzLgiJQuZDcILwkV9vefXDCm41Dy
oHfsuvHDUPodKAZmNaP64d+/tTJVMt5At5ikMQEfYAteczJwLwba1KFPI/CvlcLAidIWchJISna892hwUBeJIwKmzjF
vHu94w+USLtPlfqbxi/PtW2clE8DYiHvAALoeypQGZgbGqTHSxUJDltNhdxMleBISGxVAIr1wbmzwEqGEcdDmrP3YMj
46lV0qJGPletInesSJIwCiAEKtEl9iTjC7Mqrzi7QRRulqGMmBwsd4Lfu/Ug0nFZJR1Q7qdx/kmnJhwugQP1QCQ+pWY
szUGMQNpmYBsRPUSR2cRVOJGZ+EveD1yOvevEcTM2LBPVAyobdTTHQQxltBbKR6AzeWViiV/d/0GPxqEqoGkA75bV08
USn6MJE0SSOZgyTtfEgkDgIw4y5tSYT8tZemIFxfyyECRwK1tm5Rek2f5AgjtFE+AXLOYlJa5trQS6sXqfdbj1DOHlk
lFkhMuZRLX2NyTm3vq6VeOg1cgKb/LcYMzZDsiReq+tYlQrpua6IDxO7lJXLO6WPJM0VxeIOkRSlfB2svhbKZKLCNil
1eazWL8MKwBZ9PRp9H7iygn6DpwlifjnuVVqm8t/SGgs4bXo1regS2GG9UHzVgjvdr5spNtRGMkOeBtP4pXa8Nuq3N2
4VmobyfYZky9jevAc0/+zXmkcBBlOIzW5iVXzWVZKwYQR1Y/whzfZFw3p62qkcTnKEU9pfdB4FEtmU9LxzhnxMw2v9R
heRKi6JBXCcpYIWp495Uz7Ztwur13vCG4j1aCDn7o+13aotizGATpbmbXTXlr3Bo2BpHDaQgCXdptD75uStpZmyom6b
YE9ftlvQS7bIPx5lK6qqMcAJsEbF0QqdKuEzs63xLgCpL/q8wuEirFt+Q0AAA==
END_CODEGEN_DATA
*/
