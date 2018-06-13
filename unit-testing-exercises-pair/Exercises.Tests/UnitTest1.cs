using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void DateFashion()
		{
			DateFashion _exercises = new DateFashion();

			int result = _exercises.GetATable(5, 10);
			Assert.AreEqual(2, result, "Input" + ":GetATable(5, 10)");

			result = _exercises.GetATable(5, 2);
			Assert.AreEqual(0, result, "Input" + ":GetATable(5, 2)");

			result = _exercises.GetATable(5, 5);
			Assert.AreEqual(1, result, "Input" + ":GetATable(5, 5)");
		}

		[TestMethod]
		public void FrontTimes()
		{
			FrontTimes _exercises = new FrontTimes();

			string result = _exercises.GenerateString("Chocolate", 2);
			Assert.AreEqual("ChoCho", result, "Input" + ":GenerateString(\"Chocolate\"), 2");

			result = _exercises.GenerateString("Chocolate", 3);
			Assert.AreEqual("ChoChoCho", result, "Input" + ":GenerateString(\"Chocolate\"), 3");

			result = _exercises.GenerateString("Abc", 3);
			Assert.AreEqual("AbcAbcAbc", result, "Input" + ":GenerateString(\"Abc\"), 3");
		}

		[TestMethod]
		public void Less20()
		{
			Less20 _exercises = new Less20();

			bool result = _exercises.IsLessThanMultipleOf20(18);
			Assert.AreEqual(true, result, "Input" + ":IsLessThanMultipleOf20(18)");

			result = _exercises.IsLessThanMultipleOf20(19);
			Assert.AreEqual(true, result, "Input" + ":IsLessThanMultipleOf20(19)");

			result = _exercises.IsLessThanMultipleOf20(20);
			Assert.AreEqual(false, result, "Input" + ":IsLessThanMultipleOf20(20)");
		}

		[TestMethod]
		public void SameFirstLast()
		{
			SameFirstLast _exercises = new SameFirstLast();

			int[] a = new int[] { 1, 2, 3 };
			bool result = _exercises.IsItTheSame(a);
			Assert.AreEqual(false, result, "Input: int[] a = {1, 2, 3})");

			int[] b = new int[] { 1, 2, 3, 1 };
			result = _exercises.IsItTheSame(b);
			Assert.AreEqual(true, result, "Input: int[] b = {1, 2, 3, 1})");

			int[] c = new int[] { 1, 2, 1 };
			result = _exercises.IsItTheSame(c);
			Assert.AreEqual(true, result, "Input: int[] c = {1, 2, 1})");
		}
	}
}

