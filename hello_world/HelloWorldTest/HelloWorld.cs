/*
* DO NOT MODIFY THIS COMMENT
* Generated by TCG
* TestItem: d4114011-8ccd-41c2-87d1-cb1033738b93
*/

using System.Collections.Generic;
using NUnit.Framework;
using System;

public class GreetTestCase
{
	private static IEnumerable<TestCaseData> PositiveTests()
	{
		yield return new TestCaseData("World", "Hello World").SetName("p1").SetDescription("");
	}
	

	[Test]
	[TestCaseSource("PositiveTests")]
	public void GreetTest(String whom, String expected)
	{
		String actual = HelloWorld.Example.Greet(whom);
		Assert.AreEqual(expected, actual);
	}
}

/*
WARNING: Modification of this comment will make it impossible to merge user-defined changes

BEGIN_CODEGEN_DATA
H4sIAAAAAAAAAFWQX0vDMBTFn1vod7j0qRtbXd1g06kg++cetgmtiIgPaXrRYNrUJN0c4nc36VZ1kEDu
zT0nv5Oztue2YbqB9SaB1Wa6nD9BcreMYbJZrWbrxN4usEBJNGaQ7iGZLGwvQaWXGvNLyAZRNOhFUXdE
adYdRPS8OxpmUZemUa/fH/ZH6UXfKM4813MrxYpXiPfKKMOJ4BypZqJQYf0Eo+NmZP1QMB3OJclxJ+T7
+FQ6tl5llXJGgXKiFCwkorZME6LQc7881ykl2xpoUJpoM7ecFVVuYqQcr5rBKdHkBu6FYppt0XZV0DJS
K3f2DHkGEnUlCyhwB/9Vgf8oJM/8Dvh3yLmAQ9kKY9RrAx34ZXSopqioZKWNGfh+y6A732bbBM6ztXxp
DtY7FpWkRn3C5LfszDHvVrDsL24Qa2n/Zfcm8g4cC/wszb9i9hvl2CdUV4TDNdTINXE4+yR5yTGsHQNr
UyM6t0qh1OGtxNmHEQWNZ+fo0gQx6wciq2zIQwIAAA==
END_CODEGEN_DATA
*/